using AutoMapper;
using AutoMapper.QueryableExtensions;
using RaterestaurantMVC.Application.Interfaces;
using RaterestaurantMVC.Application.ViewModels.Restaurant;
using RaterestaurantMVC.Domain.Interfaces;
using RaterestaurantMVC.Domain.Model;
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
        private readonly IOpinionRepository _opinionRepository;
        private readonly IMapper _mapper;

        public RestaurantService(IRestaurantRepository restaurantRepository, IOpinionRepository opinionRepository, IMapper mapper)
        {
            _restaurantRepository = restaurantRepository;
            _opinionRepository = opinionRepository;
            _mapper = mapper;
        }

        public int AddRestaurant(NewRestaurantVm restaurant)
        {
            var newRestestaurant = _mapper.Map<Restaurant>(restaurant);
            var id = _restaurantRepository.AddRestaurant(newRestestaurant);
            return id;
        }

        public void DeleteRestaurant(int restaurantId)
        {
            _restaurantRepository.DeleteRestaurant(restaurantId);
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
        }

        public RestaurantEditVm GetRestaurantById(int restaurantId)
        {
            var restaurant = _restaurantRepository.GetRestaurantById(restaurantId);
            var restrautntVm = _mapper.Map<RestaurantEditVm>(restaurant);

            return restrautntVm;
        }

        public RestaurantDetailsVm GetRestaurantDetails(int restaurantId)
        {
            var restaurant = _restaurantRepository.GetRestaurantById(restaurantId);
            var restaurantVm = _mapper.Map<RestaurantDetailsVm>(restaurant);

            return restaurantVm;
        }

        public void UpdateRestaurant(RestaurantEditVm model)
        {
            var restaurant = _mapper.Map<Restaurant>(model);
            _restaurantRepository.UpdateRestaurant(restaurant);
        }
    }
}
