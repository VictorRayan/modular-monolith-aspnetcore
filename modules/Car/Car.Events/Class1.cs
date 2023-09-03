namespace Car.Events;

public class Class1
{

    public String carName
    {
        get;
        set;
    }

    public Class1(int id)
    {
        if (id == 1)
        {
            this.carName = "Ferrari";
        }
        else if (id == 2)
        {
            this.carName = "Lamborghini";
        }
    }
}