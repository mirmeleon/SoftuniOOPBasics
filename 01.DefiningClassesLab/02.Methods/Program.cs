using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main()
        {
            BankAccount bc = new BankAccount();
            bc.Deposit(2.2);
            Console.WriteLine(bc.ToString());
          
        }
    }

