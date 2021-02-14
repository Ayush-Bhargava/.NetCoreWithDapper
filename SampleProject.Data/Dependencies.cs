using SampleProject.Data.ConnectionConfiguration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProject.Data
{
    public static class Dependencies
    {
        public static IServiceCollection RegisterDapperData(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionConfguration = new ConnectionString(configuration.GetConnectionString("SampleProjectConnection"));
            //InitDapper();
            services
                .AddSingleton<IConnectionString>(connectionConfguration)
                .AddTransient<IDapperQuery, DapperQuery>();

            return services;
        }
    }
}
