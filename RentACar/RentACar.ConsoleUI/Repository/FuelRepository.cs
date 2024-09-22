using Microsoft.Extensions.DependencyInjection;
using RentACar.ConsoleUI.Data;
using RentACar.ConsoleUI.Interface;
using RentACar.ConsoleUI.Model;

namespace RentACar.ConsoleUI.Repository;

[Injectable(ServiceLifetime.Singleton)]
public class FuelRepository : IRepository<Fuel>
{
    private readonly List<Fuel> _fuels;

    public FuelRepository()
    {
        this._fuels = new FuelData().GetAll();   
    }

    public void Add(Fuel data)
    {
        _fuels.Add(data);
    }

    public void Delete(Fuel data)
    {
        _fuels.Remove(data);
    }

    public IEnumerable<Fuel> GetAll()
    {
        return _fuels;
    }

    public Fuel? GetById(int id)
    {
        return _fuels.SingleOrDefault(x => x.Id == id);
    }

    public void Update(Fuel data)
    {
        Console.WriteLine(data);
    }
}
