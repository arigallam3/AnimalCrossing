using AnimalCrossingWebApp.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalCrossingWebApp.Config
{
    public static class IocExtensions
    {
        public static IServiceCollection RegisterDependencies(this IServiceCollection services)
        {
            services.AddScoped<IVillagerRepository, VillagerRepository>();
            return services;
        }
    }
}
