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
            _context.Opinions.Add(opinion);
            _context.SaveChanges();
            return opinion.Id;
        }

        public void DeteleOpinion(int opinionId)
        {
            //pobieram, spradzam, usuam, zapisuj
            var opinion = _context.Opinions.Find(opinionId);
            if (opinion != null)
            {
                _context.Opinions.Remove(opinion);
                _context.SaveChanges();
            }
        }

        public IQueryable<Opinion> GetAllRestaurantOpinions(int restaurantId)
        {
            var opinions = _context.Opinions.Where(i => i.RestaurantId == restaurantId);
            return opinions;
        }
    }
}
