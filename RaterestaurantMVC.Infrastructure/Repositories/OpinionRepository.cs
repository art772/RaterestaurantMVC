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

        public IQueryable<Opinion> GetAllOpinions()
        {
            throw new NotImplementedException();
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
