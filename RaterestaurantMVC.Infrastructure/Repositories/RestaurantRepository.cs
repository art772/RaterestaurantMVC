using RaterestaurantMVC.Domain.Interfaces;
using RaterestaurantMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = RaterestaurantMVC.Domain.Model.Type;

namespace RaterestaurantMVC.Infrastructure.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {
        private readonly Context _context;
        public RestaurantRepository(Context context)
        {
            _context = context;
        }

        public int AddRestaurant(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return restaurant.Id;
        }

        public void DeleteRestaurant(int restaurantId)
        {
            var restaurant = _context.Restaurants.Find(restaurantId);
            if (restaurant != null)
            {
                _context.Restaurants.Remove(restaurant);
                _context.SaveChanges();
            }
        }

        public IQueryable<Type> GetAllTypes()
        {
            var types = _context.Types;
            return types;
        }

        public IQueryable<Restaurant> GetAllRestaurants()
        {
            var restaurants = _context.Restaurants;
            return restaurants;
        }

        public Restaurant GetRestaurantById(int restaurantId)
        {
            var restaurant = _context.Restaurants.FirstOrDefault(r => r.Id == restaurantId);
            return restaurant;
        }

        public IQueryable<Restaurant> GetRestaurantsByTypeId(int typeId)
        {
            var type = _context.Types.Where(t => t.Id == typeId);
            var restaurants = _context.Restaurants.Where(r => r.RestaurantTypes == type);
            return restaurants;
        }

        public void UpdateRestaurant(Restaurant restaurant)
        {
            _context.Attach(restaurant);
            _context.Entry(restaurant).Property("Name").IsModified = true;
            _context.Entry(restaurant).Property("Street").IsModified = true;
            _context.Entry(restaurant).Property("BuildingNumber").IsModified = true;
            _context.Entry(restaurant).Property("FlatNumber").IsModified = true;
            _context.Entry(restaurant).Property("ZipCode").IsModified = true;
            _context.Entry(restaurant).Property("City").IsModified = true;
            _context.Entry(restaurant).Property("Email").IsModified = true;
            _context.Entry(restaurant).Property("PhoneNumberFirst").IsModified = true;
            _context.Entry(restaurant).Property("PhoneNumberSecond").IsModified = true;
            _context.Entry(restaurant).Property("RestaurantPicture").IsModified = true;

            //_context.Restaurants.Update(restaurant);
            _context.SaveChanges();
        }

        public void UpdateRestaurantRate(Restaurant restaurant)
        {
            _context.Restaurants.Update(restaurant);
            _context.SaveChanges();
        }

        public IQueryable<Restaurant> GetRestaurantsWithLimit(int limit)
        {
            var restaurants = _context.Restaurants.OrderByDescending(r => r.AvgRate).Take(limit);
            return restaurants;
        }
    }
}
