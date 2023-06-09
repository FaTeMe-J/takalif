using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(".مقادیر مورد نظر را وارد نکرده اید", "!اخطار");
            } 
            else 
            {
                int x, y, sum ;
                x= Convert.ToInt16(textBox1.Text);
                y= Convert.ToInt16(textBox2.Text);
                sum = x + y;
                label3.Text= "Sum is : "+Convert.ToString(sum);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x, y, sub;
            x = Convert.ToInt16(textBox1.Text);
            y = Convert.ToInt16(textBox2.Text);
            sub = x - y;
            label3.Text = "Sub is : " + Convert.ToString(sub);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")

            { 
                button1.Enabled = false; 
            }
            else 
            {
                button1.Enabled = true; 
            }
            if (textBox1.Text == "" || textBox2.Text == "")

            {
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = true;
            
            }
            if (textBox1.Text == "" || textBox2.Text == "")

            {
                button5.Enabled = false;
            }
            else
            {
                button5.Enabled = true;
            }
            if (textBox1.Text == "" || textBox2.Text == "")

            {
                button6.Enabled = false;
            }
            else
            {
                button6.Enabled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x, y, mul;
            x = Convert.ToInt16(textBox1.Text);
            y = Convert.ToInt16(textBox2.Text);
            mul = x * y;
            label3.Text = "Mul is : " + Convert.ToString(mul);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int x, y, div;
            x = Convert.ToInt16(textBox1.Text);
            y = Convert.ToInt16(textBox2.Text);
            div = x / y;
            label3.Text = "Div is : " + Convert.ToString(div);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.Blue;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor= Color.Red;
        }
    }
}