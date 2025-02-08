using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// check all varities in code share file or in notes file about static functions

namespace staticfunctiondemo
{
    class abcd
    {
        static int a = 1;
        public static void count()
        {
           
            a = a + 1;
            Console.WriteLine($"The value of a : {a}");
        }
        static void Main(string[] args)
        {


            count();// directy can be called 
            Console.ReadLine();

        }

    }
     class Program
    {
       
    }
}
