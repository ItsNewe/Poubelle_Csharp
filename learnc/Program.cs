using System;
using System.Collections.Generic;
using System.IO;
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
            Console.WriteLine("Hello World!"); //Will print "Hello WOrld!" when called
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
        class Cat
        {
            public static int count = 0; //a static member makes it belong to the class itself, No matter how many objects of the class are created, there is only one copy of the static member.
            public Cat()
            {
                count++; //Cat +1
            }
        }

        class Clients //#13
        {
            private string[] names = new string[10];

            public string this[int index]
            {
                get
                {
                    return names[index];
                }
                set
                {
                    names[index] = value;
                }
            }
        }

        class Box //[#14]
        {
            public int Height { get; set; }
            public int Width { get; set; }
            public Box(int h, int w)
            {
                Height = h;
                Width = w;
            }
        }
        //INHERITANCE
        class Animal //We define our base class
        {
            public int Legs { get; set; }
            public int Age { get; set; }
        }

        class dog : Animal //Then we define our derived class
        {
            public dog()  //All public members of Animal become public members of Dog. That is why we can access the Legs member in the Dog constructor.
            {
                Legs = 4;
            }
            public void Bark()
            {
                Console.Write("Woof");
            }
        }

        //GENERIC METHODS
        static void Swap<T>(ref T ai, ref T bi) //T is a generic type (we can use it with <int>,<string>...), see #852
        {
            T temp = ai;
            ai = bi;
            bi = temp;
        }
        //END OF METHODS

        //CLASSES & OBJECTS

        //CLASSES
        class Person
        {
            private int age; //Can't be accessed from public, field
            private string name; //Can't be accessed from public, can be replaced by the following property if no custom logic is needed

            //readonly

            private readonly string NAme = "John"; //The readonly modifier prevents a member of a class from being modified after construction.
                                                   //It means that the field declared as readonly can be modified only when you declare it or from within a constructor.

            protected int agE { get; set; }
            protected string namE { get; set; }

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
                set
                {
                    if (value > 0)
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

        class Student : Person
        {
            public Student(string nm)
            {
                Name = nm;
            }

            public void Speak()
            {
                Console.Write("Name: " + Name);
            }
        }

        class Dog
        {
            public string name;
            public int age;
            public static void Bark() //Static members can be called using the class name itself, following the example at #12 [CTRL+F]
            {
                Console.WriteLine("Woof");
            }
            public Dog()
            {
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

        //GENERIC CLASSES
        class Stack<T> //Same as generic methods but for classes, #853
        {
            int index = 0;
            T[] innerArray = new T[100];
            public void Push(T item)
            {
                innerArray[index++] = item;
            }
            public T Pop()
            {
                return innerArray[--index];
            }
            public T Get(int k) { return innerArray[k]; }
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
            Console.WriteLine(bob.age);

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
                    //  Console.Write(someNums[k, j] + " "); // []= 1 dimension, [,] = 2 dimensions, [, ,] = 3 dimensions, and so on
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

            Dog.Bark(); //#12
            // Outputs "Woof"

            string str = "Hello World"; //An indexer allows objects to be indexed like an array. 
            char r = str[4];
            Console.WriteLine(r);
            //Outputs "o"


            Clients cl = new Clients(); //[#13]
            cl[0] = "Dave";
            cl[1] = "Bob";

            Console.WriteLine(c[1]); //When calling for the Client class, we use indexes
                                     //Outputs "Bob"  

            Box b1 = new Box(14, 3);  //We would like to add these two Box objects, which would result in a new, bigger Box.
            Box b2 = new Box(5, 7);   //So, basically, we would like the following code to work
                                      /*Box b3 = b1 + b2;

                                      Console.WriteLine(b3.Height); //19
                                      Console.WriteLine(b3.Width); //10 */

            dog d = new dog();
            Console.WriteLine(d.Legs);
            // Outputs 4

            d.Bark();
            //Outputs "Woof"

            //Up to this point, we have worked exclusively with public and private access modifiers.
            //Public members may be accessed from anywhere outside of the class, while access to private members is limited to their class. 
            //The protected access modifier is very similar to private with one difference; it can be accessed in the derived classes.So, a protected member is accessible only from derived classes
            Student s = new Student("David");
            s.Speak();//Outputs "Name: David"


            //ERROR HANDLING
            int result = 0;
            int num1 = 8;
            int num2 = 4;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine(result); //executes whether an exception is thrown or not
            }

            //FILES
            string stri = "Some text";
            File.WriteAllText("test.txt", stri); //Creates a file with the specified path and writes the given param to it

            string txt = File.ReadAllText("test.txt");
            Console.WriteLine(txt); //This reads from the file and outputs it's content

            /*
             * The following methods are available in the File class:
            AppendAllText() - appends text to the end of the file.
            Create() - creates a file in the specified location.
            Delete() - deletes the specified file.
            Exists() - determines whether the specified file exists.
            Copy() - copies a file to a new location.
            Move() - moves a specified file to a new location */

            int ai = 4, bi = 9; //852
            Swap<int>(ref a, ref b);
            //Now b is 4, a is 9

            string xi = "Hello";
            string yi = "World";
            Swap<string>(ref xi, ref yi);
            //Now x is "World", y is "Hello"

            Stack<int> intStack = new Stack<int>(); //#853
            Stack<string> strStack = new Stack<string>();
            Stack<Person> PersonStack = new Stack<Person>();

            intStack.Push(3);
            intStack.Push(6);
            intStack.Push(7);

            Console.WriteLine(intStack.Get(1));

            //COLLECTIONS
            List<string> colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Pink");
            colors.Add("Blue");

            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
            /*Outputs
            Red
            Green
            Pink
            Blue
            */

            /*
             * Add adds an element to the List.
                Clear removes all elements from the List.
                Contains determines whether the specified element is contained in the List.
                Count returns the number of elements in the List.
                Insert adds an element at the specified index.
                Reverse reverses the order of the elements in the List.
                So why use Lists instead of arrays?
                Because, unlike arrays, the group of objects you work with in a collection can grow and shrink dynamically. */

            /* Commonly used generic collection types include:
             * Dictionary<TKey, TValue> represents a collection of key/value pairs that are organized based on the key.
            List<T> represents a list of objects that can be accessed by index. Provides methods to search, sort, and modify lists.
            Queue<T> represents a first in, first out (FIFO) collection of objects.
        S   tack<T> represents a last in, first out (LIFO) collection of objects.*/
        }
        //ENUMS
        enum Days { Sun, Mon, Tue = 4, Wed, Thu, Fri, Sat }; //0,1,4,5...
int daynum = (int)Days.Tue; //Outputs 4
enum TrafficLights { Green, Red, Yellow };
}
}
