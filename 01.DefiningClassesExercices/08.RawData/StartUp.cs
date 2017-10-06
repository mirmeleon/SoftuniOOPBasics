using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int lines = int.Parse(Console.ReadLine());
        var cars = new List<Car>();
        for (int i = 0; i < lines; i++)
        {
            var tokens = Console.ReadLine().Split(' ');

            string model = tokens[0];
            int engineSpeed = int.Parse(tokens[1]);
            int enginePower = int.Parse(tokens[2]);
            int cargoWeight = int.Parse(tokens[3]);
            string cargoType = tokens[4];
            double tireOnePressure = double.Parse(tokens[5]);
            int tireOneAge = int.Parse(tokens[6]);
            double tireTwoPressure = double.Parse(tokens[7]);
            int tireTwoAge = int.Parse(tokens[8]);
            double tireTreePressure = double.Parse(tokens[9]);
            int tireTreeAge = int.Parse(tokens[10]);
            double tireFourPressure = double.Parse(tokens[11]);
            int tireFourAge = int.Parse(tokens[12]);

            var car = new Car(model, engineSpeed, enginePower, cargoWeight, cargoType, tireOnePressure, tireOneAge,
                tireTwoPressure, tireTwoAge, tireTreePressure, tireTreeAge, tireFourPressure, tireFourAge);
            cars.Add(car);
        }

        var last = Console.ReadLine();

        if (last == "fragile")
        {
            var res =
                cars
                    .Where(c => c.Tires.All(tr => tr.TireOnePressure < 1))
                    .Where(c => c.Cargo.CargoType == "fragile")
                    .ToList();


            foreach (var c in res)
            {
                Console.WriteLine($"{c.Model}");
            }

        }
        else
        {
            var res =
                cars.Where(c => c.Cargo.CargoType == "flamable")
                    .Where(c => c.Engine.EnginePower > 250).ToList();
            foreach (var c in res)
            {
                Console.WriteLine($"{c.Model}");
            }


        }
    }
}