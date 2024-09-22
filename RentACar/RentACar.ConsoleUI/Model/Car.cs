namespace RentACar.ConsoleUI.Model;

public class Car
{
    public int Id { get; set; }
    public int ColorId { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public string CarState { get; set; }
    public int? KiloMeter { get; set; }
    public short? ModelYear { get; set; }
    public string? Plate { get; set; }
    public string? BrandName { get; set; }
    public string? ModelName { get; set; }
    public double? DailyPrice { get; set; }

    public override string ToString()
    {
        return $"Car Details:\n" +
               $"- ID: {Id}\n" +
               $"- Brand: {BrandName ?? "Unknown"}\n" +
               $"- Model: {ModelName ?? "Unknown"}\n" +
               $"- Color ID: {ColorId}\n" +
               $"- Fuel Type ID: {FuelId}\n" +
               $"- Transmission Type ID: {TransmissionId}\n" +
               $"- State: {CarState}\n" +
               $"- Kilometer: {KiloMeter?.ToString() ?? "Not specified"}\n" +
               $"- Model Year: {ModelYear?.ToString() ?? "Not specified"}\n" +
               $"- Plate: {Plate ?? "Not specified"}\n" +
               $"- Daily Price: {DailyPrice?.ToString("C") ?? "Not specified"}";
    }
}
