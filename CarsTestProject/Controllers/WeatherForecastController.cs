using CarsTestProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarsTestProject.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<Car>> Get()
    {
        var car = new Car();
        var cars = car.GetCars();

        cars.OrderBy(x => x.CarBrand).ThenBy(y => y.CarType);

        string previousCarBrand = cars.First().CarBrand;
        string previousCarType = cars.First().CarType;
        string previousTransmission = cars.First().TransmissionType;
        for (int i = 1; i < cars.Count; i++)
        {
            var currentCarBrand = cars[i].CarBrand;
            var currentCarType = cars[i].CarType;
            var currentTransmission = cars[i].TransmissionType;

            if (string.Equals(previousCarBrand, currentCarBrand))
            {
                cars[i].CarBrand = string.Empty;
            }
            else
            {
                previousCarBrand = cars[i].CarBrand;
            }

            if (string.Equals(previousCarType, currentCarType))
            {
                cars[i].CarType = string.Empty;
            }
            else
            {
                previousCarType = cars[i].CarType;
            }

            if (string.Equals(previousTransmission, currentTransmission))
            {
                cars[i].TransmissionType = string.Empty;
            }
            else
            {
                previousTransmission = cars[i].TransmissionType;
            }
        }

        return cars;
    }
}
