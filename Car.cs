// Car.cs 
public class Car
{
    private IEngine _engine;

    public Car(IEngine engine) /// ← Constructor injects abstraction
    {
        _engine = engine;
    }

    public void StartCar()
    {
        _engine.Start(); // Care does not konow/ care about type of engine
    }
}
