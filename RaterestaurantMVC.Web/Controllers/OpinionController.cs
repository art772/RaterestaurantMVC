using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RaterestaurantMVC.Application.Interfaces;
using RaterestaurantMVC.Application.ViewModels.Opinion;
using RaterestaurantMVC.Domain.Model;
using System.Net;

namespace RaterestaurantMVC.Web.Controllers
{
    public class OpinionController : Controller
    {
        private readonly IOpinionService _opinionService;
        private readonly IRestaurantService _restaurantService;
        private readonly UserManager<ApplicationUser> _userManager;

        public OpinionController(IOpinionService opinionService, IRestaurantService restaurantService, UserManager<ApplicationUser> userManager)
        {
            _opinionService = opinionService;
            _restaurantService = restaurantService;
            _userManager = userManager;
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddOpinion(NewOpinionVm model)
        {
            model.UserId = Int32.Parse(_userManager.GetUserId(User));
            _opinionService.AddOpinion(model);
            _restaurantService.UpdateRestaurantRate(model.Rate, model.RestaurantId);

            return RedirectToAction("ViewRestaurant", "Restaurant", new { id = model.RestaurantId });
        }

        [Authorize]
        public IActionResult DeleteOpinion(int id)
        {
            _opinionService.DeleteOpinion(id);

            return RedirectToAction("Index", "Restaurant");
        }

        public IActionResult MyOpinions()
        {
            var userId = Int32.Parse(_userManager.GetUserId(User));
            var model = _opinionService.GetOpinionsByUserId(userId);

            return View(model);
        }
    }
}
