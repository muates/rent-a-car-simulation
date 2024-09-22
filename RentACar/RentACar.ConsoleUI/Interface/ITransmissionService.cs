using RentACar.ConsoleUI.Model;

namespace RentACar.ConsoleUI.Interface;

public interface ITransmissionService
{
    void Add(Transmission transmission);
    void Update(int id, string name);
    void Delete(int id);
    Transmission GetById(int id);
    List<Transmission> GetAll();
}
