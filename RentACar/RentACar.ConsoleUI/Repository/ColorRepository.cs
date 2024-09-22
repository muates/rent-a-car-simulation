using Microsoft.Extensions.DependencyInjection;
using RentACar.ConsoleUI.Data;
using RentACar.ConsoleUI.Interface;
using RentACar.ConsoleUI.Model;

namespace RentACar.ConsoleUI.Repository;

[Injectable(ServiceLifetime.Singleton)]
public class ColorRepository : IRepository<Color>
{
    private readonly List<Color> _colors;

    public ColorRepository()
    {
        this._colors = new ColorData().GetAll();
    }

    public void Add(Color data)
    {
        _colors.Add(data);
    }

    public void Delete(Color data)
    {
        _colors.Remove(data);
    }

    public IEnumerable<Color> GetAll()
    {
        return _colors;
    }

    public Color? GetById(int id)
    {
        return _colors.SingleOrDefault(x => x.Id == id);
    }

    public void Update(Color data)
    {
        Console.WriteLine(data);
    }
}
