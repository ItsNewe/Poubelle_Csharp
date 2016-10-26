using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter first value... ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second value...");
                int y = Convert.ToInt32(Console.ReadLine());

                int sum = x + y;
                Console.WriteLine("{0}", sum);
                
                Console.ForegroundColor = ConsoleColor.Red;
                   Console.WriteLine("Do you want to run another instance? Y/N ");
                Console.ResetColor();
                Char exit = Console.ReadKey().KeyChar;
                if(exit == 'Y')
                {
                    break;
                }
                Console.WriteLine(Environment.NewLine);
                /* Console.Write("Enter wanted operator...");
                 var sum = x + Console.ReadKey().KeyChar + y;
                 switch (sum)
                 {
                     case '+' :
                         Console.WriteLine("Result: {0}", sum);
                         break;
                     case '-' :
                         Console.WriteLine("Result: {0}", sum);
                         break;
                     case '*':
                         Console.WriteLine("Result: {0}", sum);
                         break;
                     case '/' :
                         Console.WriteLine("Result: {0}", sum);
                         break; 

                 }  */
            }
            while (true);
        }
    }
}
