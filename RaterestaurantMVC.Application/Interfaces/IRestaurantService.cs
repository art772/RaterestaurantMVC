using RaterestaurantMVC.Application.ViewModels.Restaurant;
using RaterestaurantMVC.Domain.Model;
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
        RestaurantEditVm GetRestaurantById(int restaurantId);
        void UpdateRestaurant(RestaurantEditVm model);
        void UpdateRestaurantRate(int rate, int restaurantId);
        RestaurantDetailsVm GetRestaurantDetails(int restaurantId);
    }
}
