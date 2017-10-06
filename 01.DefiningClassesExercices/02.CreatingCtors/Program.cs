using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CreatingCtors
{
   public class Program
    {
       public static void Main()
       {
           var type = typeof(Person);
           var emptyCtor = type.GetConstructor(new Type[] {});
           var ageCtor = type.GetConstructor(new[] {typeof(int)});
           var nameAgeCtor = type.GetConstructor(new[] {typeof(string), typeof(int)});

            bool swapped = false;
            if (nameAgeCtor == null)
            {
                nameAgeCtor = type.GetConstructor(new[] { typeof(int), typeof(string) });
                swapped = true;
            }

            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Person basePerson = (Person)emptyCtor.Invoke(new object[] { });
            Person personWithAge = (Person)ageCtor.Invoke(new object[] { age });
            Person personWithAgeAndName = swapped ? (Person)nameAgeCtor.Invoke(new object[] { age, name }) : (Person)nameAgeCtor.Invoke(new object[] { name, age });

            Console.WriteLine("{0} {1}", basePerson.name, basePerson.age);
            Console.WriteLine("{0} {1}", personWithAge.name, personWithAge.age);
           Console.WriteLine("{0} {1}", personWithAgeAndName.name, personWithAgeAndName.age);


       }
    }
}
