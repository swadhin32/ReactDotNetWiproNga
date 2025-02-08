using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace staticvariabledemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class JointAccount
        {
           static int balance = 10000;
            public void withdraw(int amt)
            {
                balance = balance - amt;
                MessageBox.Show("The Current balance : " + balance);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            JointAccount wife = new JointAccount();
            wife.withdraw(Convert.ToInt32(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JointAccount hausband = new JointAccount();
            hausband.withdraw(Convert.ToInt32(textBox1.Text));
        }
    }
}
