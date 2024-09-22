using RentACar.ConsoleUI.Model;

namespace RentACar.ConsoleUI.Interface;

public interface IFuelService
{
    void Add(Fuel fuel);
    void Update(int id, string name);
    void Delete(int id);
    Fuel GetById(int id);
    List<Fuel> GetAll();
    Fuel? GetFuelByName(string name);
}
