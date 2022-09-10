using RaterestaurantMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Application.ViewModels.Restaurant
{
    public class NewRestaurantVm : IMapFrom<RaterestaurantMVC.Domain.Model.Restaurant>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string? FlatNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumberFirst { get; set; }
        public string? PhoneNumberSecond { get; set; }
        public byte[]? RestaurantPicture { get; set; }
        public int UserId { get; set; }

        public void Mapping(MappingProfile profile)
        {
            profile.CreateMap<NewRestaurantVm, RaterestaurantMVC.Domain.Model.Restaurant>();
        }

    }
}
