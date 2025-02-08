using System;

namespace eventdelegatedemo
{
    class Program
    {
        public Program()
        {
            myevent = new mydelegate(testfuction);

        }
        public void testfuction()
        {
            Console.WriteLine("function is called ...");
        }
        public delegate void mydelegate();
        public event mydelegate myevent;
        static void Main(string[] args)
        {
            Program pp = new Program();
            pp.myevent();
            //dynamically aslos u can write like this 

            new Program().myevent();
            Console.ReadLine();
        }
    }
}
