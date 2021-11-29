using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccprogram
{
    public class harmonicnumber
    {
        static float sum(int n)
        {
            double i, s = 0.0;

            for (i = 1; i <= n; i++)
                s = s + 1 / i;

            return (float)s;
        }


        // Driven Program 
        public static void sum()
        {
            Console.WriteLine("Enter the value of n");
            int n = (Convert.ToInt32(Console.ReadLine()));
            
            Console.WriteLine("Sum is " + sum(n));

        }
    }
}


     
