﻿using AutoMapper;
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
        public OpinionForListVm GetRestaurantOpinions(int restaurantId)
        {
            var opinions = _opinionRepository.GetAllRestaurantOpinions(restaurantId);
            var opinionVm = _mapper.Map<OpinionForListVm>(opinions);

            return opinionVm;
        }
        //public int AddOpinion(OpinionVm opinion)
        //{
        //    throw new NotImplementedException();
        //}

        //public void DeleteOpinion()
        //{
        //    throw new NotImplementedException();
        //}

        //public ListOpinionForListVm GetAllOpinionsForList()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
