 public class Tire
{
    private double tireOnePressure;
    private int tireOneAge;

    public Tire(double tireOnePressure, int tireOneAge)
    {
        this.TireOnePressure = tireOnePressure;
        this.TireOneAge = tireOneAge;
    }

    public double TireOnePressure
    {
        get { return this.tireOnePressure; }
        set { this.tireOnePressure = value; }
    }

    public int TireOneAge
    {
        get { return this.tireOneAge; }
        set { this.tireOneAge = value; }
    }
}