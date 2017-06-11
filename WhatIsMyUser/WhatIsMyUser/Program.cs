using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsMyUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What Is My User | A simple test program by Newe\nInitialized at [{DateTime.Now}]\n");

            Console.Write("Your computer is running a ");
            if (Environment.Is64BitOperatingSystem == true)
            {
                Console.Write("64 bits");
            }
            else
            {
                Console.Write("32 bits");
            }
            Console.WriteLine($" version of {Environment.OSVersion}");
            Console.WriteLine($"It is equiped with a {Environment.ProcessorCount} cores CPU");
            Console.WriteLine($"The name of this machine on the current network is: {Environment.MachineName}");
            Console.WriteLine($"Your local username is: {Environment.UserName}");
            Console.WriteLine($"CLR v{Environment.Version}");
            Console.WriteLine($"This machine is running since {Environment.TickCount / 60000}m");

            Console.ReadKey();
        }
    }
}
