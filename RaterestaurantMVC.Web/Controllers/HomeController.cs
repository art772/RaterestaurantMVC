using Microsoft.AspNetCore.Mvc;
using RaterestaurantMVC.Application.Interfaces;
using RaterestaurantMVC.Web.Models;
using System.Diagnostics;

namespace RaterestaurantMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRestaurantService _restaurantService;

        public HomeController(ILogger<HomeController> logger, IRestaurantService restaurantService)
        {
            _logger = logger;
            _restaurantService = restaurantService;
        }

        public IActionResult Index()
        {
            var model = _restaurantService.GetTopRatedRestaurantsWithLimit(4);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}