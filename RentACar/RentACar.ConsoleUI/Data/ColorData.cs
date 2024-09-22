using RentACar.ConsoleUI.Model;

namespace RentACar.ConsoleUI.Data;

public class ColorData
{
    List<Color> colors = new List<Color>
    {
        new Color { Id = 1, Name = "Red" },
        new Color { Id = 2, Name = "Blue" },
        new Color { Id = 3, Name = "Black" },
        new Color { Id = 4, Name = "White" },
        new Color { Id = 5, Name = "Silver" },
        new Color { Id = 6, Name = "Gray" },
        new Color { Id = 7, Name = "Green" }
    };

    public List<Color> GetAll()
    {
        return colors;
    }
}
