using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {

   
        CalcClass calc = new CalcClass();
        static int zcnt = 0;
        static int ecnt = 0;
        static double d = 0;
        static double m = 0;
        static int lcnt = 0;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void numbers_click(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;

                
                
                if (btn.Text == ",")
                {
                    zcnt++;

                }


                if (display.Text == "0" && btn.Text == ",")
                {
                    display.Text += btn.Text;
                    zcnt++;
                }


                if (display.Text == "0" || display.Text == calc.result.ToString() || display.Text == "ERROR")
                {
                    display.Text = btn.Text;
                }

                else
                {
                    if (zcnt > 1 && btn.Text == "," || display.Text.Count() == 15)
                    {
                        display.Text += "";
                    }
                    else
                    {
                        display.Text += btn.Text;
                    }
                }

            }
            catch
            {
                display.Text = "ERROR";
            }
            


        }

        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            zcnt = 0;
            if (display.Text == "0" || display.Text == "" || display.Text == "ERROR")
            {
                display.Text = "0";

            }
            else
            {
                calc.first_number = double.Parse(display.Text);
                calc.operation = btn.Text;
                display.Text = "";
            }
            ecnt = 0;
        }

        private void result_click(object sender, EventArgs e)
        {
            ecnt++;
            if (display.Text == "")
            {
                calc.second_number = calc.first_number;
                calc.calculate();
                display.Text = calc.result.ToString();
            }
            else
            {
                if (ecnt == 2)
                {
                    calc.second_number = double.Parse(display.Text);
                    calc.calculate();
                    display.Text = calc.result.ToString();
                    d = calc.second_number;
                }
                else
                {
                    calc.first_number = double.Parse(display.Text);
                    calc.second_number = d;
                    calc.calculate();
                    display.Text = calc.result.ToString();
                }
            }

            zcnt = 0;
        }

        private void other_operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Text)
            {
                case "C":
                    display.Text = "0";
                    calc.first_number = 0;
                    calc.second_number = 0;
                    calc.result = 0;
                    calc.operation = "";
                    zcnt = 0;
                    ecnt = 0;
                    //calc = new CalcClass();
                    break;
                case "±":
                    display.Text = (double.Parse(display.Text) * -1).ToString();
                    break;
                case "←":
                    display.Text = del(display.Text);
                    break;
                case "√":
                    if (display.Text.Contains("-"))
                    {
                        display.Text = "ERROR";
                    }
                    else
                    {
                        display.Text = Math.Sqrt(double.Parse(display.Text)).ToString();
                    }
                    break;
                case "1/x":
                    display.Text = (1 / double.Parse(display.Text)).ToString();
                    break;
                case "%":
                    display.Text = (double.Parse(display.Text) * calc.first_number / 100).ToString();
                    break;
                case "sin":
                    display.Text = (Math.Sin(double.Parse(display.Text) * Math.PI / 180)).ToString();
                    break;
                case "cos":
                    display.Text = (Math.Cos(double.Parse(display.Text) * Math.PI / 180)).ToString();
                    break;
                case "tan":
                    display.Text = (Math.Tan(double.Parse(display.Text) * Math.PI / 180)).ToString();
                    break;
                case "ctan":
                    display.Text = (1 / Math.Tan(double.Parse(display.Text) * Math.PI / 180)).ToString();
                    break;
                case "n!":
                    Factorial();
                    break;
                case "x²":
                    display.Text = (Math.Pow(double.Parse(display.Text), 2)).ToString();
                    break;
                case "MS":
                    label1.Text = "M";
                    m = double.Parse(display.Text);
                    display.Text = "0";

                    break;
                case "MC":
                    //display.Text = "0";
                    m = 0;
                    label1.Text = "";

                    break;
                case "MR":
                    display.Text = m.ToString();
                    break;
                case "M+":
                    
                    label1.Text = "M";
                    m += double.Parse(display.Text);

                    break;
                case "M-":
                   
                    label1.Text = "M";
                    m -= double.Parse(display.Text);
                    break;
                case "CE":
                    display.Text = "0";
                    break;





            }
        }


        private string del(string arr)
        {
            char[] c = arr.ToCharArray();
            string s = "";
            for (int i = 0; i < c.Length - 1; i++)
            {
                s += c[i];

            }

            if (s.Length == 0)
            {
                return "0";
            }
            else
            {
                return s;
            }
        }

        private void Factorial()
        {
            if (display.Text.Contains(",") || display.Text.Contains("-"))
            {
                display.Text = "ERROR";
            }
            else
            {
                double n = double.Parse(display.Text);
                double f = 1;
                for (int i = 2; i <= n; i++)
                {
                    f *= i;
                }
                display.Text = f.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    
    }
}
 