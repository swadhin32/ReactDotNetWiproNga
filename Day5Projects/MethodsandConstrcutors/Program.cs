using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsandConstrcutors
{

    class Customer
    {
        public int customerid;
        public string custname;

        public Customer()//default constructor
        {
            Console.WriteLine("Default constructor");
            this.customerid = 1001;
            this.custname = "Suresh";
            Console.WriteLine($"{customerid}--{custname}");
                
        }
        ~Customer()
        {

            Console.WriteLine("I am destructor when the object goes out of scope i will be called");
           
        }
        static Customer()
        {
            Console.WriteLine("static constructor");
        }
        public Customer(int cid,string custname1)
        {
            Console.WriteLine("paramaized construcotr");
            this.customerid = cid;
            this.custname = custname1;
            Console.WriteLine($"{customerid}--{custname}");

        }
        
        public Customer(Customer c)
        {
            Console.WriteLine("Copy constructor");
            this.customerid = c.customerid;
            this.custname = c.custname;
            Console.WriteLine($"{customerid}--{custname}");
        }
    }
     class Program
    {
        public static void ShowMessage(int age =25,string name="Mr.X")//optional paramters
        {
            Console.WriteLine($"The person with name {name} is having age {age}");
        }
        static void Main(string[] args)
        {
            Customer defaultcons = new Customer();//default
            Customer defaultcons2 = new Customer();//default
            Customer paraconst = new Customer(1002,"sudha");
            Customer paraconst2 = new Customer(1003, "shanthi");//paramatized 
            Customer cc5 = new Customer(paraconst2);
            Customer cc6 = new Customer(defaultcons);
            ShowMessage(23, "Mahesh");
            ShowMessage(name: "suresh", age: 25);//named parameters as per my order ;
            ShowMessage();
            ShowMessage(name: "kiran");
            ShowMessage(29);
            Console.ReadLine();

            string s1;
          

        }
    }
}
