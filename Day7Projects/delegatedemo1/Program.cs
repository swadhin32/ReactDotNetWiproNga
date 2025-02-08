using System;
// check versions in code file for this program 
namespace delegatedemo1
{
    internal class Program
    {
        //public static void add(int x, int y)
        //{
        //    Console.WriteLine($"The sum is :{x + y}");
        //    Console.WriteLine("hai");
        //}

        //public static int substract(int x, int y)
        //{
        //    return (x - y);
        //}

        //public static int multiply(int x, int y)
        //{
        //    return (x * y);
        //}

        // public delegate retuntypeoffunction delegatename(parameters in function)
        public delegate void mydelegate1(int x, int y);
        public delegate int mydelegate2(int x, int y);
        static void Main(string[] args)
        {

            mydelegate1 m1 = (x, y) => { Console.WriteLine($"The sum is :{x + y}"); Console.WriteLine("hai"); };
            m1(12, 5);
            mydelegate2 m2 = (x, y) => { return (x - y); };
            Console.WriteLine($"The substaction:{m2(12, 4)}");
            m2 += (x, y) => { return (x * y); };
            Console.WriteLine($"The multiplication:{m2(12, 4)}");

            Console.ReadLine();

        }
    }
}
