using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RaterestaurantMVC.Application.Interfaces;

namespace RaterestaurantMVC.Web.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        public IActionResult Index()
        {
            var model = _restaurantService.GetAllRestaurants();
            return View(model);
        }
    }
}
