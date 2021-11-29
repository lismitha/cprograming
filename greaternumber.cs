using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccprogram
{
    public class greaternumber
    {
        public static void greaterthenthreenum()
        {
            int Num1 ,Num2 ,Num3;

            Console.WriteLine("Enter the value of Num1:");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Num2:");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Num3:");
            Num3 = Convert.ToInt32(Console.ReadLine());

            if (Num1 > Num2)
            {
                if (Num1 > Num3)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (Num2 > Num3)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");
        }
    }
}
