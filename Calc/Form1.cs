using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        
        int a, b, c;
        string s;
        public Form1()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var jam= new Class1();
            var zarb =new Class2();
            var taghsim = new Class3();

            b = Convert.ToInt32(textBox1.Text);
            switch (s)
            {
                case "+":c =jam.sum(a,b);
                    break;
                case "*":c = zarb.Mul(a,b);
                    break;
                case "/":c = taghsim.Div(a, b);
                    break;
                case "-":c = a - b;
                    break;
                default:
                    break;
            }



            textBox1.Text = c.ToString();

            label2.Text = null;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            label2.Text = a + " *";

            s = "*";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            label2.Text = a + " /";

            s = "/";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            label2.Text = a + " -";

            s = "-";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            textBox1.Text ="";
            label2.Text = a + " +";

            s = "+";
           
        }
    }
}
