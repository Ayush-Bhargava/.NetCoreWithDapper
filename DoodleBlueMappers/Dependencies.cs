using Microsoft.Extensions.DependencyInjection;
using AutoMapper;

namespace DoodleBlueMappers
{
    public static class Dependencies
    {
        public static IServiceCollection RegisterAutoMappers(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Dependencies).Assembly);
            return services;
        }
    }
}
