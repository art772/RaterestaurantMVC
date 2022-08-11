using AutoMapper;
using AutoMapper.QueryableExtensions;
using RaterestaurantMVC.Application.Interfaces;
using RaterestaurantMVC.Application.ViewModel.Restaurant;
using RaterestaurantMVC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Application.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;

        public RestaurantService(IRestaurantRepository restaurantRepository, IMapper mapper)
        {
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
        }

        public int AddRestaurant(NewRestaurantVm restaurant)
        {
            throw new NotImplementedException();
        }

        public void DeleteRestaurant(int restaurantId)
        {
            throw new NotImplementedException();
        }

        public ListRestaurantForListVm GetAllRestaurants()
        {
            var restaurants = _restaurantRepository.GetAllRestaurants()
                .ProjectTo<RestaurantForListVm>(_mapper.ConfigurationProvider).ToList();

            var restaurantList = new ListRestaurantForListVm()
            {
                Restaurants = restaurants,
                Count = restaurants.Count
            };

            return restaurantList;

            //var restaurants = _restaurantRepository.GetAllRestaurants();
            //ListRestaurantForListVm result = new ListRestaurantForListVm();
            //result.Restaurants = new List<RestaurantForListVm>();

            //foreach (var restaurant in restaurants)
            //{
            //    var restVm = new RestaurantForListVm()
            //    {
            //        Id = restaurant.Id,
            //        Name = restaurant.Name
            //    };
            //    result.Restaurants.Add(restVm);
            //}
            //return result;
        }

        public RestaurantDetailsVm GetRestaurantDetails(int restaurantId)
        {
            //var restaurant = _restaurantRepository.GetRestaurantById(restaurantId);
            //var restaurantVm = _mapper.Map<RestaurantDetailsVm>(restaurant);

            //return restaurantVm;

            throw new NotImplementedException();
        }
    }
}
