using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Exceptiondemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = a / b;
                textBox3.Text = c.ToString();
            }
            //int a; 


            catch (DivideByZeroException ex)
            {

                MessageBox.Show("dont enter denominator as zero :" + ex.Message);
            }
            catch (FormatException ex)
            {

                MessageBox.Show("dont enter charcters or special symbols :" + ex.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("some genrral error " + ex.Message);
            }

            finally
            {
                MessageBox.Show("I am still alive ");
            }


        }
        public class AdultContentException : ApplicationException
        {
            public AdultContentException(string message) : base(message)
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Convert.ToInt32(textBox4.Text);
                if (age < 18)
                {
                    AdultContentException obj = new AdultContentException("Adult Content Exception :Age should be above 18 to access");
                    throw obj;
                }
                else
                {
                    System.Diagnostics.Process.Start(new ProcessStartInfo
                    {
                        FileName = "https://www.qorno.com/",
                        UseShellExecute = true
                    });
                }
            }
            catch (AdultContentException axisobj)
            {

                MessageBox.Show(axisobj.Message);
            }

           
        }
    }
}
