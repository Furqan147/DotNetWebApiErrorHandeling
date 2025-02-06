using EventScheduler.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EventScheduler.Services
{
    public static class Register
    {
        public static void RegisterEventSchedulerServices(this IServiceCollection serviceProvider)
        {
            //add all services in this library that need to be registered here.
            serviceProvider.AddScoped<IEventDataService, EventDataService>();
        }
    }
}
