using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        public static void add(int x, int y)
        {
            Console.WriteLine($"The sum is :{x + y}");
        }

        public static int substract(int x, int y)
        {
            return (x - y);
        }

        public static int multiply(int x, int y)
        {
            return (x * y);
        }

        public delegate void mydelegate1(int x, int y);
        public delegate int mydelegate2(int x, int y);
        static void Main(string[] args)
        {
            mydelegate1 m1 = add;
            m1(12, 4);
            m1.Invoke(13, 6);
            // mydelegate1 m2 = substract; // not pointing because return type is different
            // so create another delegate
            mydelegate2 m2 = substract;
            Console.WriteLine($"substraction is : {m2(12, 4)}");
            // now multiply is also having same return type i can do multicasting of delegate
            m2 += multiply;
            Console.WriteLine($"Multiplication is: {m2(12, 8)}");

            add(12, 4); // compile time

            Console.ReadLine();
        }
    }
}
