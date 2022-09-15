using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RaterestaurantMVC.Application.Interfaces;
using RaterestaurantMVC.Application.ViewModels.Restaurant;
using RaterestaurantMVC.Domain.Model;

namespace RaterestaurantMVC.Web.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService _restaurantService;
        private readonly IOpinionService _opinionService;
        private readonly UserManager<ApplicationUser> _userManager;

        public RestaurantController(IRestaurantService restaurantService, IOpinionService opinionService ,UserManager<ApplicationUser> userManager)
        {
            _restaurantService = restaurantService;
            _opinionService = opinionService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var model = _restaurantService.GetAllRestaurants();
            return View(model);
        }


        [HttpGet]
        [Authorize(Roles = "SuperAdmin, Admin, Restaurator")]
        public IActionResult AddRestaurant()
        {
            return View(new NewRestaurantVm());
        }

        [HttpPost]
        [Authorize(Roles = "SuperAdmin, Admin, Restaurator")]
        public async Task<IActionResult> AddRestaurant(NewRestaurantVm model)
        {
            model.UserId = Int32.Parse(_userManager.GetUserId(User));
            
            if (Request.Form.Files.Count > 0)
            {
                IFormFile file = Request.Form.Files.FirstOrDefault();
                using (var dataStream = new MemoryStream())
                {
                    await file.CopyToAsync(dataStream);
                    model.RestaurantPicture = dataStream.ToArray();
                }
            }

            _restaurantService.AddRestaurant(model);
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ViewRestaurant(int id)
        {
            ViewBag.Id = id;
            var model = _restaurantService.GetRestaurantDetails(id);
            model.Opinions = _opinionService.GetRestaurantOpinions(id);

            return View(model);
        }

        public IActionResult DeleteRestaurant(int id)
        {
            _opinionService.DeleteAllRestaurantOpinion(id);
            _restaurantService.DeleteRestaurant(id);

            TempData["success"] = "Restauracja została usunięta";
            
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditRestaurant(int id)
        {
            var model = _restaurantService.GetRestaurantById(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRestaurant(RestaurantEditVm model)
        {
            if (Request.Form.Files.Count > 0)
            {
                IFormFile file = Request.Form.Files.FirstOrDefault();
                using (var dataStream = new MemoryStream())
                {
                    await file.CopyToAsync(dataStream);
                    model.RestaurantPicture = dataStream.ToArray();
                }
            }

            _restaurantService.UpdateRestaurant(model);

            return RedirectToAction("ViewRestaurant", new { id = model.Id });
        }
    }
}
