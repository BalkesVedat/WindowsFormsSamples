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
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public string Oprt { get; set; }
        public double Result { get; set; }
        public bool IsResult { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void Write(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
                txtResult.Text = "";

            if (IsResult)
            {
                txtResult.Text = "";
                IsResult = false;
            }

            txtResult.Text += ((Button)sender).Text;
        }

        private void Operation(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string op = btn.Text;


            if (op != "=")
            {
                Number1 = Convert.ToDouble(this.txtResult.Text);
                Oprt = op;
                txtMessage.Text = Number1.ToString() + " " + Oprt;
                IsResult = true;
            }
            else
            {
                Number2 = Convert.ToDouble(this.txtResult.Text);
                switch (Oprt)
                {
                    case "+":
                        Result = Number1 + Number2;
                        break;
                    case "-":
                        Result = Number1 - Number2;
                        break;
                    case "*":
                        Result = Number1 * Number2;
                        break;
                    case "/":
                        if (Number2 == 0)
                        {
                            Result = 0;
                        }
                        else
                        {
                            Result = Number1 / Number2;
                        }
                        break;
                        //default:
                        //    Result = Number1;
                        //    break;
                }

                txtMessage.Text = "";

                if (Number1 == 0)
                    txtMessage.Text += "";
                else
                    txtMessage.Text += Number1.ToString();

                txtMessage.Text += " " + Oprt;

                if (Number2 == 0)
                    txtMessage.Text += "";
                else
                    txtMessage.Text += Number2.ToString();

                txtMessage.Text += "=";

                if (Number1 == 0)
                {
                    txtResult.Text = Number2.ToString();
                }
                else
                {
                    txtResult.Text = Result.ToString();
                }

                IsResult = true;
            }




            //Button btn = (Button)sender;
            //string op = btn.Text;

            //if (op != "=")
            //{
            //    Number1 = Convert.ToDouble(txtResult.Text);
            //    Oprt = op;
            //    txtMessage.Text = Number1 + " " + Oprt;
            //    IsResult = true;   
            //}
            //else
            //{
            //    Number2 = Convert.ToDouble(txtResult.Text);

            //    switch (Oprt)
            //    {
            //        case "+":
            //            Result = Number1 + Number2;
            //            break;
            //        case "-":
            //            Result = Number1 - Number2;
            //            break;
            //        case "*":
            //            Result = Number1 * Number2;
            //            break;
            //        case "/":
            //            if (Number2 == 0)
            //            {
            //                Result = 0;
            //                return;
            //            }
            //            Result = Number1 / Number2;
            //            break;
            //    }

            //    txtMessage.Text = Number1 + " " + Oprt + " " + Number2 + " =";
            //    txtResult.Text = Result.ToString();

            //    IsResult = true;
            //}



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    Button btn = (Button)item;
                    // btn.BackColor = Color.Red;


                }



            }


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
            Operation(sender, e);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Operation(sender, e);
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Operation(sender, e);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Operation(sender, e);
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Operation(sender, e);
        }
    }
}
