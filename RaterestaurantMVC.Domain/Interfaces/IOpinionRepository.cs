using RaterestaurantMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Domain.Interfaces
{
    public interface IOpinionRepository
    {
        int AddOpinion(Opinion opinion);
        void DeteleOpinion(int opinionId);
        void DeleteAllRestaurantOpinion(int restaurantId);
        IQueryable<Opinion> GetAllRestaurantOpinions(int restaurantId);
        IQueryable<Opinion> GetOpinionsByUserId(int userId);
    }
}
