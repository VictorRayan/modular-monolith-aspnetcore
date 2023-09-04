using Car.Events.CustomEventArgs;

namespace Car.Events.EventListeners;

public class CarEvent
{
    public CarCustomEventArgs? carCustomEventArgs
    {
        get;
        set;
    }

    public void OnEventRaised(object sender, CarCustomEventArgs e)
    {
        this.carCustomEventArgs = e; 
        Console.WriteLine("Event was raised by " + sender.ToString());
    }
}