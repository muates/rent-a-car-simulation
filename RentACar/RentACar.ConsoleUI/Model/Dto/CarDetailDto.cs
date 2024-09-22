namespace RentACar.ConsoleUI.Model.Dto;

public class CarDetailDto
{
    public int Id { get; set; }
    public string? FuelName { get; set; }
    public string? TransmissionName { get; set; }
    public string? ColorName { get; set; }
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
               $"- Color: {ColorName ?? "Unknown"}\n" +
               $"- Fuel: {FuelName ?? "Unknown"}\n" +
               $"- Transmission: {TransmissionName ?? "Unknown"}\n" +
               $"- State: {CarState}\n" +
               $"- Kilometer: {KiloMeter?.ToString() ?? "Not specified"}\n" +
               $"- Model Year: {ModelYear?.ToString() ?? "Not specified"}\n" +
               $"- Plate: {Plate ?? "Not specified"}\n" +
               $"- Daily Price: {DailyPrice?.ToString("C") ?? "Not specified"}";
    }

}
