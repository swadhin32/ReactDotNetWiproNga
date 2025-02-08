using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtualfunctions
{

    class BaseClass
    {
        public virtual void display()
        {
            Console.WriteLine("Base class display..");
        }
    }
    class SubClass :BaseClass
    {
        //public override void display()
        //{
        //    Console.WriteLine("Sub Class class display..");
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass objbase;
            objbase = new SubClass();
            objbase.display();
            Console.ReadLine();
        }
    }
}
