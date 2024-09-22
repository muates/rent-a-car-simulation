using Microsoft.Extensions.DependencyInjection;
using RentACar.ConsoleUI.Interface;
using RentACar.ConsoleUI.Model;
using RentACar.ConsoleUI.Model.Dto;
using RentACar.ConsoleUI.Repository;

namespace RentACar.ConsoleUI.Service;

[Injectable(ServiceLifetime.Singleton)]
public class CarService : ICarService
{
    private readonly IRepository<Car> _carRepository;
    private readonly IFuelService _fuelService;
    private readonly ITransmissionService _transmissionService;
    private readonly IColorService _colorService;

    public CarService
        (
            IRepository<Car> carRepository, 
            IFuelService fuelService, 
            ITransmissionService transmissionService, 
            IColorService colorService
        )
    {
        this._carRepository = carRepository;
        this._fuelService = fuelService;
        this._transmissionService = transmissionService;
        this._colorService = colorService;
    }

    public void Add(Car car)
    {
        _carRepository.Add(car);
    }

    public void Delete(int id)
    {
        Car car = GetById(id);
        _carRepository.Delete(car);
    }

    public List<Car> GetAll()
    {
        return (List<Car>) _carRepository.GetAll();
    }

    public Car GetById(int id)
    {
        Car car = _carRepository.GetById(id);
        Fuel fuel = _fuelService.GetById(car.FuelId);
        Transmission transmission = _transmissionService.GetById(car.TransmissionId);
        Color color = _colorService.GetById(car.ColorId);

        if (car is null)
        {
            throw new ArgumentException("Car does not found!");
        }

        return car;
    }

    public void Update(int id, int kiloMeter, double dailyPrice)
    {
        Car car = GetById(id);

        car.KiloMeter = kiloMeter;
        car.DailyPrice = dailyPrice;

        _carRepository.Update(car);
    }

    public CarDetailDto GetCarDetailById(int id) 
    {
        Car car = _carRepository.GetById(id);
        var fuel = _fuelService.GetById(car.FuelId);
        var transmission = _transmissionService.GetById(car.TransmissionId);
        var color = _colorService.GetById(car.ColorId);

        return ConvertToCarDetailDto(car, fuel, transmission, color);
    }

    public List<CarDetailDto> GetAllCarDetails()
    {
        return GetAll().Select(car =>
        {
            var fuel = _fuelService.GetById(car.FuelId);
            var transmission = _transmissionService.GetById(car.TransmissionId);
            var color = _colorService.GetById(car.ColorId);

            return ConvertToCarDetailDto(car, fuel, transmission, color);
        }).ToList();
    }

    private CarDetailDto ConvertToCarDetailDto(Car car, Fuel fuel, Transmission transmission, Color color)
    {
        return new CarDetailDto()
        {
            Id = car.Id,
            FuelName = fuel.Name,
            TransmissionName = transmission.Name,
            ColorName = color.Name,
            CarState = car.CarState,
            KiloMeter = car.KiloMeter,
            ModelYear = car.ModelYear,
            Plate = car.Plate,
            BrandName = car.BrandName,
            ModelName = car.ModelName,
            DailyPrice = car.DailyPrice,
        };
    }
}
