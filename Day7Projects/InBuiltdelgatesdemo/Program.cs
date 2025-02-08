using System;

namespace InBuiltdelgatesdemo
{
    internal class Program
    {
        public static void add(int a, float b, decimal k)
        {
            Console.WriteLine($"The sum is:{a + Convert.ToDecimal(b) + k}");
        }

        public static double add(int a, decimal b, double kk)
        {
            return (a + Convert.ToDouble(b) + kk);

        }

        public static bool checklength(string str)
        {
            if (str.Length > 10)
                return true;
            else
                return false;
        }
        // public delegate void mydelegate1(int a, float b, decimal k);
        // public delegate double mydelegate2(int a, decimal b, double kk);
        // public delegate bool mydelegate3(string str);
        static void Main(string[] args)
        {


            Action<int, float, decimal> m1 = add;
            m1(12, 34.5F, 345.34M);
            Func<int, decimal, double, double> m2 = add;

            Predicate<string> m3 = checklength;
            Console.WriteLine($"The additon is :{m2(12, 234.45M, 234.345)}");
            Console.WriteLine($"The string is having length more than 10 :{m3("Raghavendra")}");
            Console.ReadLine();

        }
    }
}
