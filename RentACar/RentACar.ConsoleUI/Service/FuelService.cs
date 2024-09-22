using Microsoft.Extensions.DependencyInjection;
using RentACar.ConsoleUI.Interface;
using RentACar.ConsoleUI.Model;
using RentACar.ConsoleUI.Repository;

namespace RentACar.ConsoleUI.Service;

[Injectable(ServiceLifetime.Singleton)]
public class FuelService : IFuelService
{
    private readonly IRepository<Fuel> _fuelRepository;

    public FuelService(IRepository<Fuel> fuelRepository)
    {
        this._fuelRepository = fuelRepository;
    }

    public void Add(Fuel fuel)
    {
        _fuelRepository.Add(fuel);
    }

    public void Delete(int id)
    {
        Fuel fuel = GetById(id);
        _fuelRepository.Delete(fuel);
    }

    public List<Fuel> GetAll()
    {
        return (List<Fuel>) _fuelRepository.GetAll();
    }

    public Fuel GetById(int id)
    {
        Fuel fuel = _fuelRepository.GetById(id);

        if (fuel is null)
        {
            throw new ArgumentException("Fuel does not found!");
        }

        return fuel;
    }

    public void Update(int id, string name)
    {
        Fuel fuel = GetById(id);

        fuel.Name = name;

        _fuelRepository.Update(fuel);
    }

    public Fuel? GetFuelByName(string name)
    {
        return _fuelRepository.GetAll()
            .FirstOrDefault(fuel => string.Equals(fuel.Name, name, StringComparison.InvariantCultureIgnoreCase));
    }
}
