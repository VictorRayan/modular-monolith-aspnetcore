using Car.Events.EventListeners;
using Car.Events.CustomEventArgs;

namespace CarStore.HttpApi.EventHandlers.Publishers;

public class CarEventPublisher
{
    public event EventHandler<CarCustomEventArgs> carEventHandler;
    public void RaiseEvent(int id)
    {
        Console.WriteLine("Event is about to be raised.");
        if (carEventHandler != null)
        {

            CarCustomEventArgs carCustomEventArgs = new CarCustomEventArgs(id);
            carEventHandler(this, carCustomEventArgs);
        }
    }

    public String GetCarById(int id)
    {
        CarEventPublisher carEventPublisher = new CarEventPublisher();
        CarEvent carEvent = new CarEvent();
        carEventPublisher.carEventHandler += carEvent.OnEventRaised;
        carEventPublisher.RaiseEvent(id);
        
        return carEvent.carCustomEventArgs.carBrand;

    }
    
}