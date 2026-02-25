using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Write(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "";

            txtResult.Text += ((Button)sender).Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType()==typeof(Button))
                {
                    Button btn = (Button)item;
                    btn.BackColor = Color.Red;


                }



            }


        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Write(sender, e);
        }



        private void btn2_Click(object sender, EventArgs e)
        {
            Write(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Write(sender, e);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Write(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Write(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Write(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Write(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Write(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Write(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Write(sender, e);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            Write(sender, e);
        }
    }
}
