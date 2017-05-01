using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learnc
{
    class Program
    {

        // METHODS ////
        static void SayHi()
        {
            Console.WriteLine("Hello World!"); //Will print "Hello World!" when called
        }

        // METHOD PARAMETERS ////
        static void Print2(int x)
        {
            Console.WriteLine(x); //Will print the given data when called
        }

        // MULTIPLE PARAMETERS ////
        int sum(int x, int y)
        {
            return x + y; //Returns the value of two given numbers (int)
        }

        // OPTIONAL ARGUMENTS ////
        static int Pow(int x, int y = 2) //if no y is defined, gives the square of the given x, if y argument is passed, it will be used as a power
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }

            return result;
        }

        // NAMED ARGUMENTS ////
        static int Area(int h, int w) //Calculates the area of a rectangle by its weight and width
        {
            return h * w;
        }

        // METHOD OVERLOADING

        static void Print(int a)            //Overloaded methods have the same names, if the Print method receives an int argument,
        {                                   //It will call the method that accepts the int parameter, etc..
            Console.WriteLine("Value: " + a);
        }
        static void Print(double a)
        {
            Console.WriteLine("Value: " + a);
        }
        static void Print(string label, double a)
        {
            Console.WriteLine(label + a);
        }

        //Factorial

        static int Fact(int num)
        {
            if (num == 1) //if equals one, exit
            {
                return 1;
            }
            return num * Fact(num - 1);
        }

        //PYRAMID

        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++) //Displays spaces needed before the first * symbol
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++) //Calculates the number of stars for each row
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
        //END OF METHODS

        //CLASSES & OBJECTS

        //CLASSES
        class Person
        {
            private int age; //Can't be accessed from public, field
            private string name; //Can't be accessed from public, can be replaced by the following property if no custom logic is needed

            /*  public Person(string nm) //Can be accessed from public, used to modify the private value
                {
                    name = nm;
                } */
            public string Name { get; set; } //property
            /*{
                get { return name; }
                set { name = value; }  //Can be omitted to create a read only property
            }*/
            public int Age
            {
                get { return age; }
                set { if (value > 0)
                        age = value;
                }
            }
            public string getName()
            {
                return name;
            }
            public void SayHi()
            {
                Console.WriteLine("Hi");
            }

        }

        class Dog
        {
            public string name;
            public int age;
            public Dog(){
                Console.WriteLine("Constructor");
                }
            ~Dog()
            {
                Console.WriteLine("Destructor");
            }
        }

        class BankAccount
        {
            private double balance = 0; //Won't be modifiable directly
            public void Deposit(double n)
            {
                balance += n;
            }
            public void Withdraw(double n)
            {
                balance -= n;
            }
            public double GetBalance() //Calls the value of the balance property
            {
                return balance;
            }
        }

        //END OF CLASSES
        static void Main(string[] args)
        {
            //Constants store value (like var) that can't be chnged from their original assignment
            const double Pi = 3.14;

            var a = 10;
                a++; //Adds 1
            Console.WriteLine(a); //Outputs 11

            /* if (condition)
            {
                if (condition2)
                {
                    // Execute this code when condition2 is true, if false, skip
                }
                // Execute this code when condition is true 
            }*/

            int num = 3;
            switch (num)
            {
                case 1: //if == 3, execute. Else skip
                    Console.WriteLine("one");
                    break; //terminates switch statement, MUST USE or execution of it continues
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                default: //Executes if non of the cases above are true (else)
                    Console.WriteLine("The default case");
                    break;
            } //Outputs "three"

            while (num < 6) //while condition is true, execute code below
            {
                Console.WriteLine(num);
                num++;
            }
            /* Outputs
            1
            2
            3
            4
            5
            */

            /* SHORTENED VERSION OF THE CODE ABOVE
             * 
             * int num = 0;
            while(++num < 6) 
            Console.WriteLine(num); */


            //A for loop executes a set of statements a specific number of times, and has the syntax:
            /* for (init; condition; increment)
               {
                   statement(s);
               }*/

            for (int x = 10; x < 15; x++) // x +[-,*..]= can also be used
                                          //the int statement can be left out
            {
                Console.WriteLine("Value of x: {0}", x);
            }
            /*
            Value of x: 10
            Value of x: 11
            Value of x: 12
            Value of x: 13
            Value of x: 14
            */



            /*A do -while loop is similar to a while loop, except that a do -while loop is guaranteed to execute at least one time.
              For example: */
            int b = 0;
            do
            {
                Console.WriteLine(b);
                b++;
            } while (b < 5);

            // Outputs
          /*0
            1
            2
            3
            4
            */
            //If the condition of the do -while loop evaluates to false, the statements in the do will still run once

            //LOGICAL OPERATORS 
            /* && = And [To return a true value, Requires all  operands to be true]
             * false + false = false
             * false + true = false
             * true + false = false
             * true + true = true */

            /* || = Or  [To return a true value, Requires at least one operand to be true]
             * false + false = false
             * false + true = true
             * true + false = true
             * true + true = true */

            /* !() = Not  [Reverses state]
             * true = false
             * false = true */


            //CONDITIONAL OPERATOR
            int age = 42;
            string msg;
            msg = (age >= 18) ? "Welcome" : "Sorry";
            /*if (age >= 18)
                msg = "Welcome";  //This block can be replaced by the ? operator wich works this way
              else                // Exp1 ? Exp2 : Exp3     
                msg = "Sorry"; */ //Exp1 is evaluated. If true, then Exp2 is evaluated and becomes the value of the entire expression. If Exp1 is false, then Exp3 is evaluated and its value becomes the value of the expression

            Console.WriteLine(msg);

            //SayHi(); //Calls the SayHi method, wich will print "Hello World!"

            Print(42); // Replaces x by the given values, and executes the method

            //sum(2, 3); //Calls the sum methodes, and executes it

            Console.WriteLine(Pow(6)); //Outputs 36

            int res = Area(w: 5, h: 8); //Calls the Area method, with the values given in the disorder. Doesn't afectates method because they are named
            Console.WriteLine(res);
        
            Console.WriteLine(Fact(6)); //Calls the Fact method
            //Outputs 720

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Environment.NewLine + "Enter wanted number of rows for the pyramid : ");
            Console.ResetColor();
            var pyrnum = Convert.ToInt32(Console.ReadLine());
            DrawPyramid(pyrnum);

            Person p = new Person(/*"David"*/); //Calls the Person class, the parameter replace the public nm 
            //Console.WriteLine(p.getName);
            p.Name = "Bob"; //Calls the Name property, wich will assign the given value to the private member
            Console.WriteLine(p.Name);
            p.SayHi();

            Dog bob = new Dog();
            bob.name = "Bobby";
            bob.age = 3;
            Console.WriteLine(bob.age); // Prints "3"

            //ARRAYS
            int[] myArray = new int[5]; //An array is an object that will hold any given number of values of the same type
                                        //Here it can hold 5 integers
            myArray[0] = 23; //Assigns the value 23 to the first element of the array (Arrays in C# are zero-indexed, wich means that 0 is the first index, 1 is the second, etc..]

            //We can provide initial values to the array when it is declared by using curly brackets:
            string[] names = new string[3] { "John", "Mary", "Jessica" };
            double[] prices = new double[4] { 3.6, 9.8, 6.4, 5.9 };


            /* string[] names = new string[] { "John", "Mary", "Jessica" };  //We can omit the size declaration when the number of elements are provided in the curly braces
               double[] prices = new double[] { 3.6, 9.8, 6.4, 5.9 }; */


            /* string[] names = { "John", "Mary", "Jessica" }; //We can even omit the new operator. The following statements are identical to the ones above
               double[] prices = { 3.6, 9.8, 6.4, 5.9 }; */

            Console.WriteLine(names[2]); //Will output the third index of the names array, wich is "Jessica"
            //for (int k = 0; k < 4; k++)
            //{
            //    foreach (int k in a)  TSL
            //    {
            //        Console.Write(k + ", ");
            //    }
            //}

            //MULTI DIMENSIONNAL ARRAYS///
            int[,] someNums = { { 2, 3 }, { 5, 6 }, { 4, 6 } }; //This array will have 3 columns and 3 rown [columns, rows]

            for (int k = 0; k < someNums.Length; k++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(someNums[k, j] + " "); // []= 1 dimension, [,] = 2 dimensions, [, ,] = 3 dimensions, and so on
                }
                Console.WriteLine(); //Goes to the next line when a row is done printing
            }

            Console.Write(someNums.Length + ", "); //Length = number of elements in the array
            Console.Write(someNums.Rank);  //Rank = number of dimensions

            int[] arr = { 2, 4, 7, 1 };
            Console.Write(arr.Max()); //Returns the largest value
            Console.Write(arr.Min()); //Returns the smallest value
            Console.Write(arr.Sum()); //Returns the sum of all elements

            //JAGGED ARRAYS///
            int[][] jaggedArr = new int[][] //First [] contains the number of arrays, seconde one tells teh number of dimensions
                {
                  new int[ ] {1,8,2,7,9},
                  new int[ ] {2,4,6},
                  new int[ ] {33,42}
                };

            int f = jaggedArr[2][1]; //Calls the 2nd element of the 3rd array
            Console.WriteLine(f);

            //STRINGS///
            string c = "some text";
            Console.WriteLine(c.Length); //Length returns the length of the string.
            //Outputs 9

            Console.WriteLine(c.IndexOf('t')); //IndexOf(value) returns the index of the first occurrence of the value within the string.
            //Outputs 5

            c = c.Insert(0, "This is "); //Insert(index, value) inserts the value into the string starting from the specified index.
            Console.WriteLine(a);
            //Outputs "This is some text"

            c = c.Replace("This is", "I am"); //Replace(oldValue, newValue) replaces the specified value in the string.
            Console.WriteLine(c);
            //Outputs "I am some text"

            if (c.Contains("some")) //Contains(value) returns true if the string contains the specified value.

                Console.WriteLine("found");
            //Outputs "found"

            c = c.Remove(4); //Remove(index) removes all characters in the string after the specified index.
            Console.WriteLine(a);
            //Outputs "I am"

            c = c.Substring(2); //Substring(index, length) returns a substring of the specified length, starting from the specified 
            Console.WriteLine(a); //index. If length is not specified, the operation continues to the end of the string.
            //Outputs "am"

            //END OF PROGRAM, EXIT CONDITION
            Console.WriteLine(Environment.NewLine + "Press any key to exit..");
            Console.ReadKey();


            
        }
    }
}
