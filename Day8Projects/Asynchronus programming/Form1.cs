using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asynchronus_programming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            label2.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Say hello");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Before dealy";

           await Task.Delay(10000);
            label2.Text = "after delay";
        }
    }
}
