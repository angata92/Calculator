using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        double val = 0;
        string oper = "";
        bool oper_pre = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (oper_pre) )
            {
                textBox1.Clear();
            }
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            oper = b.Text;
            val = double.Parse(textBox1.Text);
            oper_pre = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch(oper)
            { 
                case "+" :
                    textBox1.Text = (val + double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (val - double.Parse(textBox1.Text)).ToString();
                    break;

                case "*":
                    textBox1.Text = (val * double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (val / double.Parse(textBox1.Text)).ToString();
                    break;
            }

            oper_pre = false;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            val = 0;

        }
    }
}
