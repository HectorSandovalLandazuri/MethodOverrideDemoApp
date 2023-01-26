// See https://aka.ms/new-console-template for more information

public abstract class Car
{
    public virtual void StartCar()
    {
        Console.WriteLine("Turn Key and Start");
    }

    public abstract void SetClock();
}
