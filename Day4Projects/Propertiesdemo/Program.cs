using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//please check code share for all versions of proeprties or your notes also 
namespace Propertiesdemo
{
    class Customer
    {
        // internally it will create public proeprty and private variable with the same name 
        // short cut implementation of above properties latest things is using this only 
        public int  CustomerID { set; get; }
        public  string  CustomerName { set; get; }   
      
       

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.CustomerID = 101;
            c1.CustomerName = "Shanthi";
            Console.WriteLine($"{c1.CustomerID}--{c1.CustomerName}");

     
            Console.ReadLine();

        }
    }
}
