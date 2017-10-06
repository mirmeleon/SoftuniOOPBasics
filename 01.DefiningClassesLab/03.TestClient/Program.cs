using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TestClient
{
   public class Program
    {
       public static void Main()
       {
           var input = Console.ReadLine();
           double amount = 0.0;
            TestClient client = new TestClient();

            while (input != "End")
            {
                var tokens = input.Split(new string []{" "}, StringSplitOptions.RemoveEmptyEntries);
                var command = tokens[0];
                var id = int.Parse(tokens[1]);


                if (tokens.Length == 3)
                {
                    amount = double.Parse(tokens[2]);
                }

                ProcessCommand(id, command, amount, client);

                input = Console.ReadLine();
           }
       }

        private static void ProcessCommand(int id, string command, double amount, TestClient client)
        {
            switch (command)
            {
                case "Create":
                  
                    client.Create(id);
                    break;
                case "Deposit":
                    client.Deposit(id, amount);
                    break;
                case "Withdraw":
                    client.Withdraw(id, amount);
                    break;
                case "Print":
                    client.Print(id);
                    break;
            }
        }
    }
}
