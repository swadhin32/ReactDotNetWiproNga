using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace AccessModifiers
{
    class abcd
    {
        private int a;
        public int b=2;
        protected int c=3;

        public void seta(int k)
        {
            this.a = k;
        }

        public int geta()
        {
            return this.a;
        }

    }
     class Program:Class1 //abcd
    {
        static void Main(string[] args)
        {
            abcd abcdobj = new abcd();
            Program pp = new Program();
            //and see which can be accessed which cannot 
            // i can touch and display b using both class objects as it is public 
            Console.WriteLine($"b i can touch using base class obj and display {abcdobj.b}");
            //  Console.WriteLine($"b i can touch using sub class obj and display {pp.b}");
            // i cannot do this 
            //abcdobj.a  // error private...
            //pp.a // error private
            // abcdobj.c // error only sub class can use even it is there in main class 
            //   Console.WriteLine($"c i can touch using sub class obj and display {pp.c}");
            // Console.WriteLine($"{abcd.c}"); //error

            //  pp.seta(1);
            // Console.WriteLine($"{pp.geta()}");
            // even after adding referecne of dll i cannot touch and print d varibale


            //abcdobj.d;

            Console.WriteLine($"Now i can touch and print {pp.d}");

            Console.ReadLine();

        }
    }
}
