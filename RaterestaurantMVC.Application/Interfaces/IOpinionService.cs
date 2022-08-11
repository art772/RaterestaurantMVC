using RaterestaurantMVC.Application.ViewModel.Opinion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Application.Interfaces
{
    public interface IOpinionService
    {
        ListOpinionForListVm GetAllOpinionsForList();
        int AddOpinion(OpinionVm opinion);
        void DeleteOpinion();
    }
}
