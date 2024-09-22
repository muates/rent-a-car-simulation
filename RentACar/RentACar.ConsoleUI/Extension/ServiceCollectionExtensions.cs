using Microsoft.Extensions.DependencyInjection;
using RentACar.ConsoleUI.Interface;
using RentACar.ConsoleUI.Service;
using System.Reflection;

namespace RentACar.ConsoleUI.Extension;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();

        var typesWithInjectable = assembly.GetTypes()
            .Where(t => t.GetCustomAttributes<InjectableAttribute>().Any() && !t.IsInterface && !t.IsAbstract);

        foreach (var type in typesWithInjectable)
        {
            var attribute = type.GetCustomAttribute<InjectableAttribute>();
            var interfaces = type.GetInterfaces();

            foreach (var @interface in interfaces)
            {
                switch (attribute.LifeTime)
                {
                    case ServiceLifetime.Singleton:
                        services.AddSingleton(@interface, type);
                        break;
                    case ServiceLifetime.Scoped:
                        services.AddScoped(@interface, type);
                        break;
                    case ServiceLifetime.Transient:
                    default:
                        services.AddTransient(@interface, type);
                        break;
                }
            }
        }

        services.AddSingleton<IServiceFactory, ServiceFactory>();

        return services;
    }
}
