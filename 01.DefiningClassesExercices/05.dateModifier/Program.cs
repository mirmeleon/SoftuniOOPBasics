using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.dateModifier
{
   public class Program
    {
       public static void Main()
       {
           string first = Console.ReadLine();
           string second = Console.ReadLine();
            DateModifier mod = new DateModifier();
          var res = mod.CalculateDifference(first, second);
           Console.WriteLine(res);
       }
    }
}
