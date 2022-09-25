using RaterestaurantMVC.Application.ViewModels.Opinion;
using RaterestaurantMVC.Application.ViewModels.Restaurant;
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
        int AddOpinion(NewOpinionVm opinion);
        void DeleteOpinion(int opinionId);
        void DeleteAllRestaurantOpinion(int restaurantId);
        ListOpinionForListVm GetOpinionsByUserId(int userId);
        ListOpinionForListVm GetRestaurantOpinions(int restaurantId);
    }
}
