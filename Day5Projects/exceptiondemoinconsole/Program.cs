﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptiondemoinconsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter value in a ...");
            int a = Convert.ToInt32(Console.ReadLine());
        L1: Console.WriteLine("enter value in b..");
            int b = Convert.ToInt32(Console.ReadLine());
            try
            {
                int c = a / b;


                Console.WriteLine("the ddivision result is {0}", c);


            }
            //comments can come nothing 
            catch (DivideByZeroException ee)
            {

                Console.WriteLine("dont enter denominator as zero:" + ee.Message);
                goto L1;

            }
            catch (FormatException ee)
            {

                Console.WriteLine("dont enter chacters and special symbols: " + ee.Message);
                goto L1;
            }
            catch (Exception ee)
            {
                Console.WriteLine("some geenral error check it :" + ee.Message);
                goto L1;
            }

            finally
            {

                Console.WriteLine("I am still alive ...");
            }

            Console.ReadLine();
        }
    }
}
