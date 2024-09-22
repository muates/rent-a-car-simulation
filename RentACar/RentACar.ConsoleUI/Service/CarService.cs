using Microsoft.Extensions.DependencyInjection;
using RentACar.ConsoleUI.Interface;
using RentACar.ConsoleUI.Model;
using RentACar.ConsoleUI.Repository;

namespace RentACar.ConsoleUI.Service;

[Injectable(ServiceLifetime.Singleton)]
public class CarService : ICarService
{
    private readonly IRepository<Car> _carRepository;

    public CarService(IRepository<Car> carRepository)
    {
        this._carRepository = carRepository;
    }

    public void Add(Car car)
    {
        _carRepository.Add(car);
    }

    public void Delete(int id)
    {
        Car car = GetById(id);
        _carRepository.Delete(car);
    }

    public List<Car> GetAll()
    {
        return (List<Car>) _carRepository.GetAll();
    }

    public Car GetById(int id)
    {
        Car car = _carRepository.GetById(id);

        if (car is null)
        {
            throw new ArgumentException("Car does not found!");
        }

        return car;
    }

    public void Update(int id, int kiloMeter, double dailyPrice)
    {
        Car car = GetById(id);

        car.KiloMeter = kiloMeter;
        car.DailyPrice = dailyPrice;

        _carRepository.Update(car);
    }
}
