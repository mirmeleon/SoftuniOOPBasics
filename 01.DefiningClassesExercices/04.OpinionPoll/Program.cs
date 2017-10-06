using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04.OpinionPoll
{
  public class Program
    {
        public static void Main()
        {
            int lines = int.Parse(Console.ReadLine());
            var ppl = new List<Person>();
            for (int i = 0; i < lines; i++)
            {
                Person per = new Person();
                var tokens = Console.ReadLine().Split(' ');
                per.Name = tokens[0];
                per.Age = int.Parse(tokens[1]);

                ppl.Add(per);
            }

             ppl
                .Where(p=>p.Age > 30)
                .OrderBy(p=>p.Name)
                .ToList()
                .ForEach(p => Console.WriteLine($"{p.Name} - {p.Age}"));
        }
    }
}
