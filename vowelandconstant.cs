using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccprogram
{
    public class vowelandconstant
    {
        public static void vowelorconstanstant()
        {
            Console.WriteLine("Enter the letter:");
            char ch = Convert.ToChar(Console.ReadLine());
            
            // Condition for vowel checking

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("{0} is vowel",ch);
            }

            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))

            {
                Console.WriteLine("{0} is constant",ch);
            }
                        

            Console.ReadLine();
        }
    }
}
