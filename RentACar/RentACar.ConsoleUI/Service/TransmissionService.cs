using Microsoft.Extensions.DependencyInjection;
using RentACar.ConsoleUI.Interface;
using RentACar.ConsoleUI.Model;
using RentACar.ConsoleUI.Repository;

namespace RentACar.ConsoleUI.Service;

[Injectable(ServiceLifetime.Singleton)]
public class TransmissionService : ITransmissionService
{
    private readonly IRepository<Transmission> _transmissionRepository;

    public TransmissionService(IRepository<Transmission> transmissionRepository)
    {
        this._transmissionRepository = transmissionRepository;
    }

    public void Add(Transmission transmission)
    {
        _transmissionRepository.Add(transmission);
    }

    public void Delete(int id)
    {
        Transmission transmission = GetById(id);
        _transmissionRepository.Delete(transmission);
    }

    public List<Transmission> GetAll()
    {
        return (List<Transmission>) _transmissionRepository.GetAll();
    }

    public Transmission GetById(int id)
    {
        Transmission transmission = _transmissionRepository.GetById(id);

        if (transmission is null)
        {
            throw new ArgumentException("Transmission does not found!");
        }

        return transmission;
    }

    public void Update(int id, string name)
    {
        Transmission transmission = GetById(id);

        transmission.Name = name;

        _transmissionRepository.Update(transmission);
    }
}
