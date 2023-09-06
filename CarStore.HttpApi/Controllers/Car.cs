using CarStore.HttpApi.EventHandlers.Publishers;
using Microsoft.AspNetCore.Mvc;

namespace CarStore.HttpApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Car : ControllerBase
{
    [HttpGet("{id}")]
    public String GetCarById(int id)
    {

        CarEventPublisher carEventPublisher = new CarEventPublisher();
        String carBrand = carEventPublisher.GetCarById(id);

        return carBrand;

    }

    [HttpGet("List/{brand}")]
    public String GetCarsListByBrand(String brand)
    {
        
        return brand;
    }
}