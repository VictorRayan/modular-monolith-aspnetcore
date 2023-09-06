using System.Diagnostics;
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
        //Console.WriteLine("Event was raised by " + sender.ToString());
        setCarBrandById();
    }

    private void setCarBrandById()
    {
        String carBrand = null;
        switch (this.carCustomEventArgs.Id)
        {
            case 1:
                carBrand = "Ferrari";
                break;
            case 2:
                carBrand = "Bugatti";
                break;
        }
        this.carCustomEventArgs.carBrand = carBrand;
    }
}