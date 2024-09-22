using Microsoft.Extensions.DependencyInjection;
using RentACar.ConsoleUI.Interface;
using RentACar.ConsoleUI.Model;
using RentACar.ConsoleUI.Repository;

namespace RentACar.ConsoleUI.Service;

[Injectable(ServiceLifetime.Singleton)]
public class ColorService : IColorService
{
    private readonly IRepository<Color> _colorRepository;

    public ColorService(IRepository<Color> colorRepository)
    {
        this._colorRepository = colorRepository;
    }

    public void Add(Color color)
    {
        _colorRepository.Add(color);
    }

    public void Delete(int id)
    {
        Color color = GetById(id);
        _colorRepository.Delete(color);
    }

    public List<Color> GetAll()
    {
        return (List<Color>) _colorRepository.GetAll();
    }

    public Color GetById(int id)
    {
        Color color = _colorRepository.GetById(id);

        if (color is null)
        {
            throw new ArgumentException("Color doest not found!");
        }

        return color;
    }

    public void Update(int id, string name)
    {
        Color color = GetById(id);

        color.Name = name;

        _colorRepository.Update(color);
    }
}
