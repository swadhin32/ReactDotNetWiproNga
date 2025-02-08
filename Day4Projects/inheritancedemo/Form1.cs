using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inheritancedemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //multi level inheritance
       sealed class Father
        {
            public void maruthicar()
            {
                MessageBox.Show("Maruthi car ...");
            }
        }
     sealed   class Son : Father
        {
            public void MBCar()
            {
                MessageBox.Show("Mercedes benz car...");
            }
        }
        class GrandSon:Son//,Father not possible 
        {
            public void BMWCar()
            {
                MessageBox.Show("BMW car....");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GrandSon grandSon = new GrandSon();
            Father fobj = new Father();
            // remove comments and check 
            //fobj.MBCar() // error not possible
            //fobj.BMWCar() // error not possible
            Son sobj = new Son();
            //sobj.BMWCar(); //errro not possible
        }
    }
}
