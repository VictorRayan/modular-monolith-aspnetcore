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
        String carName = carEventPublisher.GetCarById(id);

        return carName;

    }
}