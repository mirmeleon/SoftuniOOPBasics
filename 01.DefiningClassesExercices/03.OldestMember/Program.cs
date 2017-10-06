using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _03.OldestMember
{
   public class Program
    {
       public static void Main()
       {
           MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
           MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
           if (oldestMemberMethod == null || addMemberMethod == null)
           {
               throw new Exception();
           }


           int lines = int.Parse(Console.ReadLine());
            Family fam = new Family();

           for (int i = 0; i < lines; i++)
           {
                Person per = new Person();
                //pesho 3
                var tokens = Console.ReadLine().Split(' ');
               per.Name = tokens[0];
               per.Age = int.Parse(tokens[1]);
                fam.AddMember(per);
           }
           var oldest = fam.GetOldestMember();
           Console.WriteLine($"{oldest.Name} {oldest.Age}");
       }
    }
}
