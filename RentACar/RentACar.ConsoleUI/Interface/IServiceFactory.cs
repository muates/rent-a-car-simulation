namespace RentACar.ConsoleUI.Interface;

public interface IServiceFactory
{
    T GetService<T>();
}
