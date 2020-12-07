using AnimalCrossingWebApp.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalCrossingWebApp.Config
{
    public static class DatabaseExtensions
    {
        public static IServiceCollection RegisterDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<VillagerContext>(options =>
            {
                options.UseSqlServer(configuration["ConnectionStrings:AnimalCrossingConnection"]);

                options.EnableSensitiveDataLogging();

            });

            return services;
        }
    }
}
