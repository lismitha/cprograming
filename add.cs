using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccprogram
{
     public class Add
    {
        public static void Addingnum()
        {
            Console.WriteLine("enter the vale value of a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the vale value of b");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;

            Console.WriteLine("adding of two number = {0}",sum);
            Console.ReadLine();
        }

    }
}
