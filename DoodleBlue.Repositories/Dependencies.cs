using System;
using System.Collections.Generic;
using System.Text;
using DoodleBlue.Repositories.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace DoodleBlue.Repositories
{
    public static class Dependencies
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            //InitDapper();
            services
                .AddTransient<ILeadRepository, LeadRepository>();

            return services;
        }
    }
}
