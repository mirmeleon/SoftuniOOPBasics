
   public class Car
   {
       private string model;
       private double fuelAmount;
       private double fuelConsumption;
       private int distanceTraveled;

       public Car(string model, double fuelAmount, double fuelConsumption)
       {
           this.distanceTraveled = 0;
           this.Model = model;
           this.FuelAmount = fuelAmount;
           this.FuelConsumption = fuelConsumption;
       }

       public string Model
       {
            get { return this.model; }
            set { this.model = value; }
       }

       public double FuelAmount
       {
           get { return this.fuelAmount; }
           set { this.fuelAmount = value; }
       }

       public double FuelConsumption
       {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
       }

       public int DistanceTraveled
       {
            get { return this.distanceTraveled; }
            set { this.distanceTraveled = value; }
       }


       public bool CanMove(int km)
       {
            var consumedFuel = km * this.FuelConsumption;

            if (this.FuelAmount >= consumedFuel)
           {
               //this.FuelAmount -= km;
               //this.distanceTraveled += km;
               return true;
           }
           else
           {
               return false;
           }
       }
   }
