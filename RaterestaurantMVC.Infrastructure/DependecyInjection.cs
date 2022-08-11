using Microsoft.Extensions.DependencyInjection;
using RaterestaurantMVC.Domain.Interfaces;
using RaterestaurantMVC.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IRestaurantRepository, RestaurantRepository>();
            services.AddTransient<IOpinionRepository, OpinionRepository>();
            return services;
        }
    }
}
