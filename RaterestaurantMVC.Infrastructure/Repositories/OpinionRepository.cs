using RaterestaurantMVC.Domain.Interfaces;
using RaterestaurantMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Infrastructure.Repositories
{
    public class OpinionRepository : IOpinionRepository
    {
        private readonly Context _context;
        public OpinionRepository(Context context)
        {
            _context = context;
        }
        public int AddOpinion(Opinion opinion)
        {
            throw new NotImplementedException();
        }

        public void DeleteOpinion(int opiniondId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Opinion> GetAllRestaurantOpinions(int restaurantId)
        {
            var opinions = _context.Opinions.Where(i => i.Id == restaurantId);
            return opinions;
        }

        public IQueryable<Opinion> GetAllUserOpinions(int userId)
        {
            var opinions = _context.Opinions.Where(i => i.Id == userId);
            return opinions;
        }

        public Opinion GetOpinion(int opinionId)
        {
            throw new NotImplementedException();
        }

        public void UpdateOpinion(Opinion opinion)
        {
            throw new NotImplementedException();
        }
    }
}
