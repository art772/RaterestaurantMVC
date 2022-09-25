using RaterestaurantMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = RaterestaurantMVC.Domain.Model.Type;

namespace RaterestaurantMVC.Domain.Interfaces
{
    public interface IRestaurantRepository
    {
        int AddRestaurant(Restaurant restaurant);
        void DeleteRestaurant(int restaurantId);
        IQueryable<Type> GetAllTypes();
        IQueryable<Restaurant> GetAllRestaurants();
        Restaurant GetRestaurantById(int restaurantId);
        IQueryable<Restaurant> GetRestaurantsByTypeId(int typeId);
        void UpdateRestaurant(Restaurant restaurant);
        void UpdateRestaurantRate(Restaurant restaurant);
        IQueryable<Restaurant> GetRestaurantsWithLimit(int limit);
        IQueryable<Restaurant> GetRestaurantByUserId(int userId);
    }
}
