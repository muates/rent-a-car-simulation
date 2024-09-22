using Microsoft.Extensions.DependencyInjection;
using RentACar.ConsoleUI.Configuration;
using RentACar.ConsoleUI.Interface;

internal class Program
{
    private static void Main(string[] args)
    {
        var serviceProvider = DependencyInjectionSetup.ConfigureServices();

        var serviceFactory = serviceProvider.GetService<IServiceFactory>();

        if (serviceFactory is null)
        {
            Console.WriteLine("ServiceFactory not found.");
            return;
        }

        try
        {
            var carService = serviceFactory.GetService<ICarService>();
            var colorService = serviceFactory.GetService<IColorService>();
            var fuelService = serviceFactory.GetService<IFuelService>();
            var transmissionService = serviceFactory.GetService<ITransmissionService>();

            carService.Update(1, 80000, 12000);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"{e.Message}");
        }
    }
}