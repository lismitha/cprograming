using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccprogram
{
    public class quotientandreminder
    {
        public static void quotientremendier()
        {
            Console.WriteLine("enter the value of X");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Y");
            int Y =(Convert.ToInt32(Console.ReadLine()));

            int quotient = X / Y;
            int reminder = X % Y;

            Console.WriteLine("quotient is:" + quotient);
            Console.WriteLine("reminder is:" + reminder);

            Console.ReadLine();
        }
    }
}
