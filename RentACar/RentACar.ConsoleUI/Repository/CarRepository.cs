using Microsoft.Extensions.DependencyInjection;
using RentACar.ConsoleUI.Data;
using RentACar.ConsoleUI.Interface;
using RentACar.ConsoleUI.Model;

namespace RentACar.ConsoleUI.Repository;

[Injectable(ServiceLifetime.Singleton)]
public class CarRepository : IRepository<Car>
{
    private readonly List<Car> _cars;

    public CarRepository()
    {
        this._cars = new CarData().GetAll();
    }

    public void Add(Car data)
    {
        _cars.Add(data);
    }

    public void Delete(Car data)
    {
        _cars.Remove(data);
    }

    public IEnumerable<Car> GetAll()
    {
        return _cars;
    }

    public Car? GetById(int id)
    {
        return _cars.SingleOrDefault(x => x.Id == id);
    }

    public void Update(Car data)
    {
        Console.WriteLine(data);
    }
}
