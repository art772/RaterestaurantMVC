using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RaterestaurantMVC.Application.Interfaces;
using RaterestaurantMVC.Application.ViewModels.Restaurant;
using RaterestaurantMVC.Domain.Model;
using System.Dynamic;

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
        public IActionResult AddRestaurant(NewRestaurantVm model)
        {
            model.UserId = Int32.Parse(_userManager.GetUserId(User));
            _restaurantService.AddRestaurant(model);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ViewRestaurant(int id)
        {
            var model = _restaurantService.GetRestaurantDetails(id);
            //var modelTwo = _opinionService.GetRestaurantOpinions(id);
            return View(model);
        }
    }
}
