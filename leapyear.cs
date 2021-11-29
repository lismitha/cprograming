using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccprogram
{
    public class leapyear
    {
        public static void Leap()
        {
            Console.WriteLine("enter the year:");
            int year =Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
                Console.WriteLine("Year is leap year");
            else
                Console.WriteLine("year is not leap year");
        }
    }
}
