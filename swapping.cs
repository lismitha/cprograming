using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccprogram
{
    public class swapping
    {
        public static void Swapingtwonum()
        {
            Console.WriteLine("Enter the value of num1:");
            int num1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value if num2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int Temp = num1;
            num1 = num2;
            num2 = Temp;

            Console.WriteLine("After swaping");
            Console.WriteLine("the value of num1={0}", num1);
            Console.WriteLine("the value of num2={0}", num2);

        }

    }
}
