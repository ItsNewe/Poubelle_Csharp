using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //NEED TO FIND A CHAR WORKAROUND
            Console.WriteLine("Enter a number..");
            int number = Convert.ToInt32(Console.ReadLine());

            if(number<0)
            {
                Console.WriteLine("The number you chose is negative");

            }
            else if(number>0)
            {
                Console.WriteLine("The number you chose is positive");
            }
            else
            {
                Console.WriteLine("You chose 0 or your input was invalid");
            }
            Console.WriteLine(Environment.NewLine + "Press a key to exit");
            Console.ReadKey();
        }
    }
}
