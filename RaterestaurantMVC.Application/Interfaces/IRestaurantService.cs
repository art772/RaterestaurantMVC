using RaterestaurantMVC.Application.ViewModels.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Application.Interfaces
{
    public interface IRestaurantService
    {
        int AddRestaurant(NewRestaurantVm restaurant);
        void DeleteRestaurant(int restaurantId);
        ListRestaurantForListVm GetAllRestaurants();
        RestaurantDetailsVm GetRestaurantDetails(int restaurantId);
    }
}
