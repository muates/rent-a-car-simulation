using Microsoft.Extensions.DependencyInjection;
using RentACar.ConsoleUI.Data;
using RentACar.ConsoleUI.Interface;
using RentACar.ConsoleUI.Model;

namespace RentACar.ConsoleUI.Repository;

[Injectable(ServiceLifetime.Singleton)]
public class TransmissionRepository : IRepository<Transmission>
{
    private readonly List<Transmission> _transmissions;

    public TransmissionRepository()
    {
        this._transmissions = new TransmissionData().GetAll();    
    }

    public void Add(Transmission data)
    {
        _transmissions.Add(data);
    }

    public void Delete(Transmission data)
    {
        _transmissions.Remove(data);
    }

    public IEnumerable<Transmission> GetAll()
    {
        return _transmissions;
    }

    public Transmission? GetById(int id)
    {
        return _transmissions.SingleOrDefault(x => x.Id == id);
    }

    public void Update(Transmission data)
    {
        Console.WriteLine(data);
    }
}
