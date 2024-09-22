using RentACar.ConsoleUI.Model;

namespace RentACar.ConsoleUI.Data;

public class FuelData
{
    List<Fuel> fuels = new List<Fuel>
    {
        new Fuel { Id = 1, Name = "Petrol" },
        new Fuel { Id = 2, Name = "Diesel" },
        new Fuel { Id = 3, Name = "Electric" },
        new Fuel { Id = 4, Name = "Hybrid" }
    };

    public List<Fuel> GetAll()
    {
        return fuels;
    }
}
