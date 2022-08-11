using RaterestaurantMVC.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Application.ViewModel.Restaurant
{
    public class RestaurantDetailsVm : IMapFrom<RaterestaurantMVC.Domain.Model.Restaurant>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string PhoneNumberFirst { get; set; }
        public string PhoneNumberSecond { get; set; }
        public double AvgRate { get; set; }

        public virtual ICollection<RaterestaurantMVC.Domain.Model.Opinion> Opinions { get; set; }

        public void Mapping(MappingProfile profile)
        {
            profile.CreateMap<RaterestaurantMVC.Domain.Model.Restaurant, RestaurantDetailsVm>()
                .ForMember(s => s.Adress, opt => opt.MapFrom(d => "ul. " + d.Street + " " + d.BuildingNumber + "/" + d.FlatNumber + ", " + d.City + "" + d.ZipCode));
        }
    }
}
