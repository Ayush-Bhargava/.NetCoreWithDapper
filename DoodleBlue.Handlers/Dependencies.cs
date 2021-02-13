using MediatR;
using Microsoft.Extensions.DependencyInjection;


namespace DoodleBlue.Handlers
{
    public static class Dependencies
    {
        public static IServiceCollection RegisterRequestHandler(this IServiceCollection services)
        {
            return services.AddMediatR(typeof(Dependencies).Assembly);
        }
    }
}
