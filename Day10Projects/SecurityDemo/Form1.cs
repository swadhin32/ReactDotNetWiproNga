using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurityDemo
{
    public partial class Form1 : Form
    {
        private AuthService _authService;
        public Form1()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; }

            public User(string username1, string password1, string role1)
            {
                Username = username1;
                Password = password1;
                Role = role1;
            }
        }

        public class  AuthService
        {
            private List<User> _users = new List<User>();

            public AuthService()
            {
                //Add some sample users with roles

                _users.Add(new User("ravi", "RaviPassword", "Admin"));
                _users.Add(new User("mahesh", "MaheshPassword", "User"));
            }

            public User Authenticate(string username, string password)
            {
                User userfound = null;
                foreach (User user1 in _users)
                {
                    if (user1.Username == username && user1.Password == password)
                    {
                        userfound = user1;
                        break;
                    }
                }
                return userfound;
            }

            public bool Authorize(User user, string role)
            {
                // checking wheather user role matches with required role
                return user.Role == role;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // authenticate user
            User user = _authService.Authenticate(username, password);
            if (user == null)
            {
                label3.Text = "Invalid username and password";
                label3.Visible = true;
                return;
            }
            // if authenticated then a open home page like that or main form

            MainForm mainform = new MainForm(user);
            mainform.Show();
            this.Hide();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
