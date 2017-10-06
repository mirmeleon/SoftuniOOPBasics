using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.dateModifier
{
   public class DateModifier
    {

        public double CalculateDifference(string firstDate, string secondDate)
        {
            var dateOne = DateTime.Parse(firstDate);
            var dateTwo = DateTime.Parse(secondDate);

         var res = Math.Abs((dateOne - dateTwo).TotalDays);

         
            return res;
        }
    }
}
