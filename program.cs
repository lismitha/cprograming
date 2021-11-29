using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basiccprogram
{
    public class program
    {
        static void Main(string[] args)
        {
            LOOP_LABEL:

            Console.WriteLine("enter the number which program need to be excute :");
            Console.WriteLine("1:add\n2:swaping\n3:quotientandreminder\n4:flipcoin\n5:leapyear\n6:evenaorodd\n7:vowelandconstant\n8:greaternumber\n9:harmonicnumber\n");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Add.Addingnum();
                    break;

                case 2:
                    swapping.Swapingtwonum();
                    break;

                case 3:
                    quotientandreminder.quotientremendier();
                    break;

                case 4:
                    flipcoin.Headortail();
                    break;
                case 5:
                    leapyear.Leap();
                    break;
                case 6:
                    evenorodd.eveandodd();
                    break;
                case 7:
                    vowelandconstant.vowelorconstanstant();
                    break;
                case 8:
                    greaternumber.greaterthenthreenum();
                    break;
                case 9:
                    harmonicnumber.sum();
                    break;

                default:
                    Console.WriteLine("please enter the number in thr above list:");
                    break;
            }
            Console.WriteLine("Do you want to run again?? Press 1 for Yes, Press 2 for No: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
                   goto LOOP_LABEL;
 
        }
    }
}
