using RentACar.ConsoleUI.Model;

namespace RentACar.ConsoleUI.Data;

public class CarData
{
    List<Car> cars = new List<Car>
    {
        new Car
        {
            Id = 1,
            ColorId = 1,
            FuelId = 1,
            TransmissionId = 1,
            CarState = "Available",
            KiloMeter = 15000,
            ModelYear = 2020,
            Plate = "34ABC123",
            BrandName = "Toyota",
            ModelName = "Corolla",
            DailyPrice = 150.00
        },
        new Car
        {
            Id = 2,
            ColorId = 2,
            FuelId = 2,
            TransmissionId = 2,
            CarState = "Unavailable",
            KiloMeter = 30000,
            ModelYear = 2018,
            Plate = "34DEF456",
            BrandName = "Ford",
            ModelName = "Focus",
            DailyPrice = 120.00
        },
        new Car
        {
            Id = 3,
            ColorId = 3,
            FuelId = 3,
            TransmissionId = 1,
            CarState = "Available",
            KiloMeter = 5000,
            ModelYear = 2022,
            Plate = "34GHI789",
            BrandName = "Tesla",
            ModelName = "Model 3",
            DailyPrice = 250.00
        },
        new Car
        {
            Id = 4,
            ColorId = 4,
            FuelId = 4,
            TransmissionId = 1,
            CarState = "Available",
            KiloMeter = 8000,
            ModelYear = 2021,
            Plate = "34JKL012",
            BrandName = "Honda",
            ModelName = "Civic",
            DailyPrice = 180.00
        }
    };

    public List<Car> GetAll()
    {
        return cars;
    }
}