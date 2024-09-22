namespace RentACar.ConsoleUI.Model;

public class Fuel
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public override string ToString()
    {
        return $"Fuel Details:\n" +
               $"- ID: {Id}\n" +
               $"- Name: {Name ?? "Unknown"}";
    }
}
