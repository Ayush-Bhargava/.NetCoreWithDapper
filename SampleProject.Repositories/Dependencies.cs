using System;
using System.Collections.Generic;
using System.Text;
using SampleProject.Repositories.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace SampleProject.Repositories
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
