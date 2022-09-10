using RaterestaurantMVC.Application.Mapping;
using RaterestaurantMVC.Application.ViewModels.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Application.ViewModels.Opinion
{
    public class NewOpinionVm : IMapFrom<RaterestaurantMVC.Domain.Model.Opinion>
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public double Rate { get; set; }
        public int UserId { get; set; }
        public int RestaurantId { get; set; }

        public void Mapping(MappingProfile profile)
        {
            profile.CreateMap<NewOpinionVm, RaterestaurantMVC.Domain.Model.Opinion>();
        }
    }
}
