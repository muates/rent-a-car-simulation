namespace RentACar.ConsoleUI.Model;

public class Color
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"Color Details:\n" +
               $"- ID: {Id}\n" +
               $"- Name: {Name ?? "Unknown"}";
    }
}
