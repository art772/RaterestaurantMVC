using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RaterestaurantMVC.Application.Mapping;

namespace RaterestaurantMVC.Application.ViewModels.Restaurant
{
    public class RestaurantForListVm : IMapFrom<RaterestaurantMVC.Domain.Model.Restaurant>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public double AvgRate { get; set; }

        public void Mapping(MappingProfile profile)
        {
            profile.CreateMap<RaterestaurantMVC.Domain.Model.Restaurant, RestaurantForListVm>()
                .ForMember(s => s.Adress, opt => opt.MapFrom(d => "ul. " + d.Street + " " + d.BuildingNumber + "/" + d.FlatNumber + ", " + d.ZipCode + " " + d.City));
        }
    }
}
