using RaterestaurantMVC.Application.ViewModels.Opinion;
using RaterestaurantMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Application.Interfaces
{
    public interface IOpinionService
    {
        //OpinionForListVm GetRestaurantOpinions(int restaurantId);
        ListOpinionForListVm GetRestaurantOpinions(int restaurantId);

        //int AddOpinion(OpinionVm opinion);
        //void DeleteOpinion();
    }
}
