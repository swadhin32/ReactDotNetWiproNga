using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstractclassandinterfacedemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public abstract class Polygon2
        {
            public abstract void area(int s);
        }
        public abstract class Polygon
        {
            public void testfunction()
            {
                MessageBox.Show("**************************");
            }
            public abstract void area(int a, int b);// abstarct method 
          //  public abstract void area(int s);
        }

        class Triangle : Polygon
        {
            public override void area(int a, int b)
            {
                MessageBox.Show("The are of Triangle is :" + 0.5 * a * b);
            }

           
        }
        class Rectangle : Polygon
        {
            public override void area(int a, int b)
            {
                MessageBox.Show("The are of rectangle is :" + (a * b));
            }
        }

        class square : Polygon2
        {
            public override void area(int s)
            {
                MessageBox.Show("The area of square is :" + (s * s));
            }
        }

        //class NewShape : Polygon, Polygon2
        //{
        //    public override void area(int a, int b)
        //    {
        //        throw new NotImplementedException();
        //    }
        //}

        interface A
        {
            // never use public in interface as by default it is public only 
           // int a;//cannot declare varibale 
           //  int a1 { set; get; }// can declare proepties 
            //public void testfunction()
            //{
            //    MessageBox.Show("**************************");
            //}
            void area(int a, int b);

        }

        interface B
        {
            void area(int s);
        }
        class NewShape : A, B
        {
           
            public void area(int a, int b)
            {
                MessageBox.Show("The are of rectangle is :" + (a * b));
            }

            public void area(int s)
            {
                MessageBox.Show("The area of square is :" + (s * s));
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // use the base class obj sub classfucntion 
            //  Polygon obj = new Polygon();// error i cannot create an object of abstract class 
            // becuse abstarct class is having partial method means incomplete methoods 
            // i cannot create an object by i can create object reference means

            Polygon obj;// it is a car without a petrol 
            obj = new Triangle();// allocating memory of trianngle class in base class only putting petrol
            obj.area(12, 3);
            obj=new Rectangle();// it can allocate memeory of rectanglealso 
            obj.area(12, 4);
            obj.testfunction();
            // now i can use base class refercne object and i can call sub class function which 
            //is happening here first limitiation of inheritnace is overcome 
            Polygon2 obj2;
            obj2 = new square();
            obj2.area(12);

            A aobj;
            aobj = new NewShape();
            aobj.area(12, 34);
            B bobj;
            bobj = new NewShape();
            bobj.area(5);

        }
    }
}
