namespace ThreadExample;
using System.Threading;
class Program
{
    public static void Fun1()
    {
        for (int i = 1; i < 20; i++)
        {
           
            Console.WriteLine("Func1() writes {0}", i);
        }

    }

    public static void Fun2()
    {
        for (int j = 20; j > 0; j--)
        {
           
            Console.WriteLine("Func2() writes {0}", j);
        }

    }
   
    static void Main(string[] args)
    {
        Thread first = new Thread(new ThreadStart(Fun1));
        Thread second = new Thread(new ThreadStart(Fun2));
        Console.WriteLine("Start of the main function ");
        second.Priority = ThreadPriority.Highest;
        first.Priority = ThreadPriority.Lowest;
        first.Start();
        second.Start();
       

       
       
        Console.WriteLine("End of main()");
    }
}
