using Microsoft.AspNetCore.Mvc;
using Car.Events;

namespace CarStore.HttpApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Car : ControllerBase
{
    [HttpGet("{id}")]
    public String GetCarById(int id)
    {
        Class1 car = new Class1(id);
        return car.carName;
    }
}