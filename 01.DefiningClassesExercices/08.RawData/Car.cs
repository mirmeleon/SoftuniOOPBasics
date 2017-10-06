
 using System.Collections.Generic;

public class Car
{

    private string model;
    private Cargo cargo;
    private Engine engine;
    private ICollection<Tire> tires;



    public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tireOnePressure,
        int tireOneAge, double tireTwoPressure, int tireTwoAge, double tireTreePressure, int tireTreeAge,
        double tireFourPressure, int tireFourAge)
    {
        this.Model = model;
        this.Cargo = new Cargo(cargoWeight, cargoType);
        this.Engine = new Engine(engineSpeed, enginePower);
        this.Tires = new List<Tire>(4);

        Tire one = new Tire(tireOnePressure, tireOneAge);
        Tire two = new Tire(tireTwoPressure, tireTwoAge);
        Tire tree = new Tire(tireTreePressure, tireTreeAge);
        Tire four = new Tire(tireFourPressure, tireFourAge);

        this.Tires.Add(one);
        this.Tires.Add(two);
        this.Tires.Add(tree);
        this.Tires.Add(four);
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public Cargo Cargo
    {
        get { return this.cargo; }
        set { this.cargo = value; }
    }

    public Engine Engine
    {
        get { return this.engine; }
        set { this.engine = value; }
    }

    public ICollection<Tire> Tires
    {
        get { return this.tires; }
        set { this.tires = value; }
    }

}
