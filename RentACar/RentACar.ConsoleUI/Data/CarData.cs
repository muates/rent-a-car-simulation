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
    },
    new Car
    {
        Id = 5,
        ColorId = 1,
        FuelId = 1,
        TransmissionId = 2,
        CarState = "Available",
        KiloMeter = 12000,
        ModelYear = 2021,
        Plate = "34MNO345",
        BrandName = "BMW",
        ModelName = "X3",
        DailyPrice = 220.00
    },
    new Car
    {
        Id = 6,
        ColorId = 2,
        FuelId = 2,
        TransmissionId = 1,
        CarState = "Available",
        KiloMeter = 3000,
        ModelYear = 2023,
        Plate = "34PQR678",
        BrandName = "Audi",
        ModelName = "A4",
        DailyPrice = 240.00
    },
    new Car
    {
        Id = 7,
        ColorId = 2,
        FuelId = 3,
        TransmissionId = 2,
        CarState = "Unavailable",
        KiloMeter = 40000,
        ModelYear = 2017,
        Plate = "34STU901",
        BrandName = "Mercedes",
        ModelName = "C-Class",
        DailyPrice = 260.00
    },
    new Car
    {
        Id = 8,
        ColorId = 3,
        FuelId = 4,
        TransmissionId = 1,
        CarState = "Available",
        KiloMeter = 20000,
        ModelYear = 2019,
        Plate = "34VWX234",
        BrandName = "Nissan",
        ModelName = "Altima",
        DailyPrice = 170.00
    },
    new Car
    {
        Id = 9,
        ColorId = 1,
        FuelId = 4,
        TransmissionId = 1,
        CarState = "Available",
        KiloMeter = 10000,
        ModelYear = 2022,
        Plate = "34XYZ567",
        BrandName = "Hyundai",
        ModelName = "Tucson",
        DailyPrice = 200.00
    },
    new Car
    {
        Id = 10,
        ColorId = 2,
        FuelId = 1,
        TransmissionId = 2,
        CarState = "Available",
        KiloMeter = 15000,
        ModelYear = 2020,
        Plate = "34ABC890",
        BrandName = "Kia",
        ModelName = "Sportage",
        DailyPrice = 190.00
    },
    new Car
    {
        Id = 11,
        ColorId = 3,
        FuelId = 3,
        TransmissionId = 1,
        CarState = "Unavailable",
        KiloMeter = 60000,
        ModelYear = 2016,
        Plate = "34DEF123",
        BrandName = "Chevrolet",
        ModelName = "Cruze",
        DailyPrice = 110.00
    },
    new Car
    {
        Id = 12,
        ColorId = 4,
        FuelId = 2,
        TransmissionId = 1,
        CarState = "Available",
        KiloMeter = 30000,
        ModelYear = 2019,
        Plate = "34GHI456",
        BrandName = "Volkswagen",
        ModelName = "Golf",
        DailyPrice = 160.00
    },
    new Car
    {
        Id = 13,
        ColorId = 1,
        FuelId = 3,
        TransmissionId = 2,
        CarState = "Available",
        KiloMeter = 5000,
        ModelYear = 2023,
        Plate = "34JKL789",
        BrandName = "Porsche",
        ModelName = "Macan",
        DailyPrice = 300.00
    },
    new Car
    {
        Id = 14,
        ColorId = 2,
        FuelId = 1,
        TransmissionId = 1,
        CarState = "Unavailable",
        KiloMeter = 45000,
        ModelYear = 2018,
        Plate = "34MNO012",
        BrandName = "Subaru",
        ModelName = "Outback",
        DailyPrice = 175.00
    },
    new Car
    {
        Id = 15,
        ColorId = 3,
        FuelId = 4,
        TransmissionId = 1,
        CarState = "Available",
        KiloMeter = 15000,
        ModelYear = 2021,
        Plate = "34PQR345",
        BrandName = "Mazda",
        ModelName = "CX-5",
        DailyPrice = 210.00
    },
    new Car
    {
        Id = 16,
        ColorId = 4,
        FuelId = 2,
        TransmissionId = 2,
        CarState = "Available",
        KiloMeter = 7000,
        ModelYear = 2022,
        Plate = "34STU678",
        BrandName = "Fiat",
        ModelName = "500",
        DailyPrice = 140.00
    },
    new Car
    {
        Id = 17,
        ColorId = 1,
        FuelId = 3,
        TransmissionId = 1,
        CarState = "Available",
        KiloMeter = 25000,
        ModelYear = 2020,
        Plate = "34VWX901",
        BrandName = "Renault",
        ModelName = "Clio",
        DailyPrice = 130.00
    },
    new Car
    {
        Id = 18,
        ColorId = 2,
        FuelId = 4,
        TransmissionId = 2,
        CarState = "Unavailable",
        KiloMeter = 35000,
        ModelYear = 2017,
        Plate = "34XYZ234",
        BrandName = "Peugeot",
        ModelName = "308",
        DailyPrice = 155.00
    }
};

    public List<Car> GetAll()
    {
        return cars;
    }
}