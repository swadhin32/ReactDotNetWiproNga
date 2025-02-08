using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListDemo
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public static List<Customer> retrive()
        {
            List<Customer> list = new List<Customer>()
            {
              new Customer{CustomerID=101,CustomerName="sita"},
              new Customer{CustomerID=102,CustomerName="suresh"},
              new Customer{CustomerID=103,CustomerName="mahesh"}

            };
            return list;
        }

        public static void PrintCustomers(List<Customer> clist)
        {
            Console.WriteLine("\n Printing customers...");
            foreach (Customer c in clist)
            {
                Console.WriteLine($"{c.CustomerID}--{c.CustomerName}");
            }
        }
        public static void insertcustomer(Customer customer,List<Customer> clist)
        {
            clist.Add(customer);
        }
        public static Customer findcustomer(int custid1,List<Customer> clist)
        {
            Customer customerfound = null;
            foreach (Customer c in clist)
            {
                if (c.CustomerID == custid1)
                {
                    customerfound = c;
                    break;
                }
            }
            return customerfound;
        }

        public static void updatecustomer(int cid,List<Customer> clist)
        {
            for(int i=0;i<clist.Count;i++)
            {
                if(clist[i].CustomerID == cid)
                {
                    Console.WriteLine("enter new name:");
                    string newname=Console.ReadLine();
                    clist[i].CustomerName = newname;
                }
            }
        }

        public static void  deletecustomer(int cid, List<Customer> clist)
        {
            for (int i = 0; i < clist.Count; i++)
            {
                if (clist[i].CustomerID == cid)
                {
                    clist.RemoveAt(i);
                }
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 12, 34, 55, 61, 29, 40 };
            List<double> numbers2 = new List<double>();
            numbers2.Add(123.23);
            numbers2.AddRange(new double[] { 111.11, 222.22, 333.33 });
            Console.WriteLine("\n displaying numbers");
            foreach(int number in numbers)
            {
                Console.Write($"{number}  ");
            }
            Console.WriteLine("\n displaying numbers2");
            foreach (double number in numbers2)
            {
                Console.Write($"{number}  ");
            }
            List<string> boysnames = new List<string>() { "kiran", "karthik", "mahesh", "suresh" };
            var girlnames = new List<string>();
            girlnames.Add("sudha");
            girlnames.AddRange(new string[] { "sita", "shanthi", "priya", "suman" });

            Console.WriteLine("\n\n displaying boys ");
            foreach (string boy in boysnames)
            {

                Console.WriteLine($"{boy}");

            }
            Console.WriteLine("\n displaying girls");
            foreach (string girl in girlnames)
            {

                Console.WriteLine($"{girl}");
            }
            int[] aa2 = new int[] { 12, 13, 23, 12, 34, 67, 23, 89, 91, 66, 71, 67 };
            // remove duplicate elelements from the array and give it to me 
            List<int> result = new List<int>();
            foreach(int number in aa2)
            {
                bool found = false;
                foreach(int resultitem in result)
                {
                    if (resultitem == number)
                    {
                        found = true;
                        break;

                    }
                   
                   
                }
                if (!found)
                {
                    result.Add(number);
                }
            }
            Console.WriteLine("\n after removing duplicate elements:");
            foreach (int k in result)
            {
                Console.Write($"{k} ");
            }
            Console.WriteLine("\n customer coding started...");
            List<Customer> custlist = Customer.retrive();
            Customer.PrintCustomers(custlist);
            Console.WriteLine("\n enter the customer to be added in the list");
            Customer c4 = new Customer()
            {
                CustomerID = 104,
                CustomerName="sharavan"
            };
            Customer.insertcustomer(c4, custlist);
            Customer.PrintCustomers(custlist);
            Console.WriteLine("\n enter the id of customer to be found ");
            int cusotmerid1=Convert.ToInt32(Console.ReadLine());
           Customer cusomergot= Customer.findcustomer(cusotmerid1, custlist);
            if(cusomergot!=null)
            {
                Console.WriteLine($"The customer with id {cusomergot.CustomerID} is having name :{cusomergot.CustomerName}");
            }
            else
            {
                Console.WriteLine("\n cusotmer not available");
            }
            Console.WriteLine("\n enter the id of customer whos name u want to change ");
            int customerid2 = Convert.ToInt32(Console.ReadLine());
            Customer.updatecustomer(customerid2, custlist);
            Customer.PrintCustomers(custlist);
            Console.WriteLine("\n enter the id of customer whos name u want to delete ");
            int customerid3 = Convert.ToInt32(Console.ReadLine());
            Customer.deletecustomer(customerid3, custlist);
            Customer.PrintCustomers(custlist);

            Console.ReadLine();
        }
    }
}
