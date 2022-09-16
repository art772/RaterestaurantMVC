using RaterestaurantMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Application.ViewModels.Restaurant
{
    public class RestaurantRateUpdateVm
    {
        public int? RateCount { get; set; }
        public int? RateSum { get; set; }
        public double? AvgRate { get; set; }

        public void Mapping(MappingProfile profile)
        {
            profile.CreateMap<RaterestaurantMVC.Domain.Model.Restaurant, RestaurantRateUpdateVm>().ReverseMap();
        }
    }
}
