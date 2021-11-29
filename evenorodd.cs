using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccprogram
{
    internal class evenorodd
    {
        public static void eveandodd()
        {
            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine("enter number is even");
            else
                Console.WriteLine("enter number is odd");
        }
    }
}
