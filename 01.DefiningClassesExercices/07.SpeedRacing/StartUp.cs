using System;
using System.Collections.Generic;
using System.Linq;


public class StartUp
    {
 
       public static void Main()
       {
           int n = int.Parse(Console.ReadLine());
            var cars = new List<Car>();

           for (int i = 0; i < n; i++)
           {
               var tokens = Console.ReadLine().Split(' ');
               var model = tokens[0];
               var fuel =int.Parse(tokens[1]);
               var consump = double.Parse(tokens[2]);

                Car car = new Car(model,fuel, consump);
                cars.Add(car);
           }

           var input = Console.ReadLine();

           while (input != "End")
           {
               var tok = input.Split(' ');
               var model = tok[1];
               var km = int.Parse(tok[2]);

              
             Car car =  cars.FirstOrDefault(c => c.Model == model);
            

               if (car.CanMove(km))
               {
                   var consumedFuel = km * car.FuelConsumption;
                   car.FuelAmount -= consumedFuel; 
                   car.DistanceTraveled += km;
              
                }
                else
               {
                    Console.WriteLine("Insufficient fuel for the drive");
               }

                input = Console.ReadLine();
            }

          
            foreach (var c in cars)
            {
                Console.WriteLine($"{c.Model} {c.FuelAmount:f2} {c.DistanceTraveled}");
            }
       }
    }
