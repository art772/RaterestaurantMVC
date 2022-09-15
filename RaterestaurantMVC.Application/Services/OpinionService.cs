using AutoMapper;
using AutoMapper.QueryableExtensions;
using RaterestaurantMVC.Application.Interfaces;
using RaterestaurantMVC.Application.ViewModels.Opinion;
using RaterestaurantMVC.Application.ViewModels.Restaurant;
using RaterestaurantMVC.Domain.Interfaces;
using RaterestaurantMVC.Domain.Model;
using RaterestaurantMVC.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Application.Services
{
    public class OpinionService : IOpinionService
    {
        private readonly IOpinionRepository _opinionRepository;
        private readonly IMapper _mapper;
        public OpinionService(IOpinionRepository opinionRepository, IMapper mapper)
        {
            _opinionRepository = opinionRepository;
            _mapper = mapper;
        }

        public int AddOpinion(NewOpinionVm opinion)
        {
            var newOpinion = _mapper.Map<Opinion>(opinion);
            var id = _opinionRepository.AddOpinion(newOpinion);

            return id;
        }

        public void DeleteAllRestaurantOpinion(int restaurantId)
        {
            _opinionRepository.DeleteAllRestaurantOpinion(restaurantId);
        }

        public void DeleteOpinion(int opinionId)
        {
            _opinionRepository.DeteleOpinion(opinionId);
        }

        public ListOpinionForListVm GetRestaurantOpinions(int restaurantId)
        {
            var opinions = _opinionRepository.GetAllRestaurantOpinions(restaurantId)
                .ProjectTo<OpinionForListVm>(_mapper.ConfigurationProvider).ToList();

            var opinionList = new ListOpinionForListVm()
            {
                Opinions = opinions,
                Count = opinions.Count
            };

            return opinionList;
        }
    }
}
