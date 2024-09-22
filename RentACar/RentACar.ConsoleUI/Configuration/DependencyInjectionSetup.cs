using Microsoft.Extensions.DependencyInjection;
using RentACar.ConsoleUI.Extension;

namespace RentACar.ConsoleUI.Configuration;

public static class DependencyInjectionSetup
{
    public static ServiceProvider ConfigureServices()
    {
        var serviceCollection = new ServiceCollection();

        serviceCollection.AddServices();

        return serviceCollection.BuildServiceProvider();
    }
}
