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
        void DeleteOpinion(int opiniondId);
        IQueryable<Opinion> GetAllRestaurantOpinions(int restaurantId);
        IQueryable<Opinion> GetAllUserOpinions(int userId);
        Opinion GetOpinion(int opinionId);
        void UpdateOpinion(Opinion opinion);
    }
}
