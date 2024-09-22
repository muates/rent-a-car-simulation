using RentACar.ConsoleUI.Model;

namespace RentACar.ConsoleUI.Data;

public class TransmissionData
{
    List<Transmission> transmissions = new List<Transmission>
    {
        new Transmission { Id = 1, Name = "Automatic" },
        new Transmission { Id = 2, Name = "Manual" }
    };

    public List<Transmission> GetAll()
    {
        return transmissions;
    }
}
