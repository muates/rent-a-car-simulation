using RentACar.ConsoleUI.Model;

namespace RentACar.ConsoleUI.Interface;

public interface IColorService
{
    void Add(Color color);
    void Update(int id, string name);
    void Delete(int id);
    Color GetById(int id);
    List<Color> GetAll();
}
