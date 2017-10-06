using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02ClassExercices
{
  public class Program
    {
        static void Main()
        {
            var type = typeof(Person);
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }

    }
    
}
