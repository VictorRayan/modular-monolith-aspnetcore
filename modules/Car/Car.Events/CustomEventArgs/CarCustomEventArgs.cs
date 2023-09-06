namespace Car.Events.CustomEventArgs;

public class CarCustomEventArgs
{
    public int Id { get; set; }
    public String? carBrand { get; set; }

    public CarCustomEventArgs(int id)
    {
        this.Id = id;
    }    
}