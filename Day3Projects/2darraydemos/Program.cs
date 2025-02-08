using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2darraydemos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, sum = 0;
            Console.WriteLine("----------------------------");
            for(i=1;i<=5;i++)
            {
                for(j=1;j<=i; j++)
                {
                    Console.Write($"{j}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------");
            int[,] a = new int[3,3];//declaring 2d array 
           
            int[,,] aa = new int[3, 3, 3];// 3d array where height is also there 

            Console.WriteLine("enter elements in 2d array..");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"enter [{i + 1},{j + 1}] element:");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nPrinting an array");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write($"{a[i, j]}  ");

                }
                Console.Write("\n");
            }

            Console.WriteLine("\n sum of elelemts in matrix");

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {

                    sum = sum + a[i, j];
                }

            }
            Console.WriteLine($"\nn the sum is {sum}");
            // if u dont know the length of 2 d aaary 

            Console.WriteLine("enter array elements in 2d array ");
            for (i = 0; i < a.GetLength(0); i++)
            {
                for (j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"enter [{i + 1},{j + 1}] element :  ");
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.ReadLine();
        }
    }
}
