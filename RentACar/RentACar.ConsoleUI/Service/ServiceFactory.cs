using RentACar.ConsoleUI.Interface;

namespace RentACar.ConsoleUI.Service;

public class ServiceFactory : IServiceFactory
{
    private readonly IServiceProvider _serviceProvider;

    public ServiceFactory(IServiceProvider serviceProvider)
    {
        this._serviceProvider = serviceProvider;
    }

    public T GetService<T>()
    {
        var service = _serviceProvider.GetService(typeof(T));
        if (service == null)
        {
            throw new ArgumentException($"Service of type {typeof(T).Name} not found.");
        }
        return (T)service;
    }
}
