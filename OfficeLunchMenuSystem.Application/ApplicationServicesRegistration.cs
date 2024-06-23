using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace OfficeLunchMenuSystem.Application
{
    public static class ApplicationServicesRegistration
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        }
    }
}
