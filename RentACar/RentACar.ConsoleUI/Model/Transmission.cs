namespace RentACar.ConsoleUI.Model;

public class Transmission
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"Transmission Details:\n" +
               $"- ID: {Id}\n" +
               $"- Name: {Name ?? "Unknown"}";
    }
}
