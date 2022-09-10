using RaterestaurantMVC.Application.Mapping;
using RaterestaurantMVC.Application.ViewModels.Opinion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Application.ViewModels.Restaurant
{
    public class RestaurantDetailsVm : IMapFrom<RaterestaurantMVC.Domain.Model.Restaurant>, IMapFrom<RaterestaurantMVC.Domain.Model.Opinion>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }
        public string PhoneNumberFirst { get; set; }
        public string PhoneNumberSecond { get; set; }
        public double AvgRate { get; set; }
        public byte[] RestaurantPicture { get; set; }

        public int RestaurantId { get; set; }
        public string Content { get; set; }
        public double Rate { get; set; }

        public ListOpinionForListVm Opinions { get; set; }

        public static void Mapping(MappingProfile profile)
        {
            profile.CreateMap<RaterestaurantMVC.Domain.Model.Restaurant, RestaurantDetailsVm>()
                .ForMember(s => s.Adress, opt => opt.MapFrom(d => "ul. " + d.Street + " " + d.BuildingNumber + "/" + d.FlatNumber + ", " + d.City + " " + d.ZipCode));

            profile.CreateMap<RaterestaurantMVC.Domain.Model.Opinion, RestaurantDetailsVm>();
        }
    }
}
