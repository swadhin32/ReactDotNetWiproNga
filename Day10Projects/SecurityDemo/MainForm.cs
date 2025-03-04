using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SecurityDemo.Form1;

namespace SecurityDemo
{
    public partial class MainForm : Form
    {
        private User _user;
        public MainForm(User user)
        {
            InitializeComponent();
            _user = user;
            label1.Text = $" Welcome ,{user.Username} ({user.Role})";

            // Enable/Disable buttons based on role
            if (_user.Role == "Admin")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }

            button2.Enabled = true; // All users can access User actions
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("admin action has performed");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("user action has performed");
        }
    }
}
