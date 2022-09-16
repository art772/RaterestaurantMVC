using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Http;
using RaterestaurantMVC.Application.Interfaces;
using RaterestaurantMVC.Application.ViewModels.Restaurant;
using RaterestaurantMVC.Domain.Interfaces;
using RaterestaurantMVC.Domain.Model;
using System.Security.Claims;

namespace RaterestaurantMVC.Application.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RestaurantService(IRestaurantRepository restaurantRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _restaurantRepository = restaurantRepository;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public int AddRestaurant(NewRestaurantVm restaurant)
        {
            var newRestestaurant = _mapper.Map<Restaurant>(restaurant);
            var id = _restaurantRepository.AddRestaurant(newRestestaurant);
            return id;
        }

        public void DeleteRestaurant(int restaurantId)
        {
            var userId = Int32.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
            var restaurant = _restaurantRepository.GetRestaurantById(restaurantId);
            
            if (userId == restaurant.UserId)
            {
                _restaurantRepository.DeleteRestaurant(restaurantId);
            }
            
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

        public void UpdateRestaurantRate(int rate, int restaurantId)
        {
            var restaurant = _restaurantRepository.GetRestaurantById(restaurantId);

            if (restaurant.RateSum == null)
            {
                restaurant.RateSum = 0;
            }

            if (restaurant.RateCount == null)
            {
                restaurant.RateCount = 0;
            }

            restaurant.RateSum = restaurant.RateSum + rate;
            restaurant.RateCount = restaurant.RateCount + 1;
            restaurant.AvgRate = Convert.ToDouble(restaurant.RateSum / restaurant.RateCount);

            _restaurantRepository.UpdateRestaurantRate(restaurant);
        }
    }
}
