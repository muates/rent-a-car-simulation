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

            var result = carService.GetAllCarDetails();
            result.ForEach(car => Console.WriteLine(car));
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"{e.Message}");
        }
    }
}