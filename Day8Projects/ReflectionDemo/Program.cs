using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ReflectionDemo
{

    public abstract class Song
    {
        public void ResumeSong()
        {
            Console.WriteLine("Song Playing..");
        }
        abstract public Song PlaySong { get; set; }
        abstract public bool StopSong { get; set; }
        abstract public bool RemoveSong { get; set; }
        abstract public int SongCount { get; set; }
    }
    class A
    {

    }
    class B : A
    {

    }
    class MyClass
    {
        int x;
        int y;
        public MyClass()
        {

        }
        public MyClass(int i, int j)
        {
            x = i;
            y = j;
        }

        public MyClass(MyClass c)
        {
            this.x = c.x;
            this.y = c.y;
        }

        public int sum()
        {
            return x + y;
        }

        public bool isBetween(int i)
        {
            if (x < i && i < y) return true;
            else return false;
        }

        public void set(int a, int b)
        {
            x = a;
            y = b;
        }

        public void set(double a, double b)
        {
            x = (int)a;
            y = (int)b;
        }

        public void show()
        {
            Console.WriteLine(" x: {0}, y: {1}", x, y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();  
            B b = new B();
            if(a is A)
            {
                Console.WriteLine("a is the object of A class ");
            }
            if(b is A)
            {
                Console.WriteLine("b is in A becasue derived from A");
            }
            // suppose i want to types of .net framework assembllies
            Type t = typeof(StreamWriter);
            Console.WriteLine($"{t.FullName}");
            Type t2 = typeof(Song);
            if(t2.IsClass)
            {
                Console.WriteLine("yes it is a class");
            }
            if(t2.IsAbstract)
            {
                Console.WriteLine("yes it is abstract");
            }
            else
            {
                Console.WriteLine("it is concnrete class");
            }

            Type tt = typeof(MyClass);
            Console.WriteLine($"checking methods in {tt.Name} class");
            Console.WriteLine("Methods involved....");
            Console.WriteLine("---------------------");
             MethodInfo[] mi= tt.GetMethods(BindingFlags.Instance |
                BindingFlags.Public | BindingFlags.DeclaredOnly);
            foreach (MethodInfo m in mi)
            {
                Console.Write($"{m.ReturnType.Name}  {m.Name}(");
                ParameterInfo[] pi = m.GetParameters();
                for (int i = 0; i < pi.Length; i++)
                {
                    Console.Write($"{pi[i].ParameterType.Name} {pi[i].Name}");
                    if (i + 1 < pi.Length)
                    {
                        Console.Write(",");
                    }
                  
                   
                }
                Console.WriteLine(")");
                Console.WriteLine();
            }
            //for reading all constructors in my class MyClass 
            ConstructorInfo[] ci = tt.GetConstructors(BindingFlags.Instance |
                BindingFlags.Public | BindingFlags.DeclaredOnly);

            // for constructors
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("constructors involved ..");
            foreach (ConstructorInfo c in ci)
            {
                Console.Write($" {c.Name}(");
                ParameterInfo[] pi1 = c.GetParameters();
                for (int i = 0; i < pi1.Length; i++)
                {
                    Console.Write($"{pi1[i].ParameterType.Name}  {pi1[i].Name}");
                    if (i + 1 < pi1.Length) Console.Write(" ,");
                }
                Console.WriteLine(")");
                Console.WriteLine();
            }
            // for song getting the type and read its properties as per the lab question 
            Console.WriteLine("\n..reading the song proeprties which is lab 1 question");
            Type ts = typeof(Song);

            PropertyInfo[] pif = ts.GetProperties(BindingFlags.DeclaredOnly |
                               BindingFlags.Instance |
                               BindingFlags.Public);

            Console.WriteLine("\nvirtual proeprties in song class ");
            Console.WriteLine("----------------------------------");
            foreach (PropertyInfo p in pif)
            {
                Console.Write($"{p.Name}  (type  ");

                if (p.PropertyType.IsClass)
                {
                    Console.Write($"{p.PropertyType.Name} )\n");
                }
                else
                {
                    Console.Write($"{p.PropertyType} )\n");
                }

            }

            Console.ReadLine();


        }
    }
}
