 public class Engine
{
    private int engineSpeed;
    private int enginePower;

    public Engine(int speed, int power)
    {
        this.EngineSpeed = speed;
        this.EnginePower = power;
    }

    public int EngineSpeed { get; set; }

    public int EnginePower { get; set; }
}