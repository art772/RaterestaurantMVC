using Microsoft.Extensions.DependencyInjection;
using RaterestaurantMVC.Application.Interfaces;
using RaterestaurantMVC.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RaterestaurantMVC.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication( this IServiceCollection services)
        {
            services.AddTransient<IRestaurantService, RestaurantService>();
            services.AddTransient<IOpinionService, OpinionService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
