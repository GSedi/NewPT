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
        CalcClass calc = new CalcClass();
        static int zcnt = 0;
        static int ecnt = 0;
        static double d = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void numbers_click(object sender, EventArgs e)
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


            if (display.Text == "0" || display.Text == calc.result.ToString() )
            {
                display.Text = btn.Text;
            }
          
            else
            {
                if (zcnt > 1&& btn.Text == ",")
                {
                    display.Text += "";
                }
                else
                {
                    display.Text += btn.Text;
                }
            }
           



        }

        private void operation_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            zcnt = 0;
            if (display.Text == "0" || display.Text == "")
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
            if (ecnt == 1)
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
                    display.Text = Math.Sqrt(double.Parse(display.Text)).ToString();
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
            double n = double.Parse(display.Text);
            double f = 1;
            for (int i = 2; i <= n; i++)
            {
                f *= i;
            }
            display.Text = f.ToString();
        }
       private void c_click(object sender, EventArgs e)
        {
            display.Text = "0";
            calc.first_number = 0;
            calc.second_number = 0;
            calc.result = 0;
            calc.operation = "";
            zcnt = 0;
            ecnt = 0;
            //calc = new CalcClass();
        }

       

        

        private void pm_click(object sender, EventArgs e)
        {
         
               display.Text = (double.Parse(display.Text) * -1).ToString();
               
           

        }

        private void bs_click(object sender, EventArgs e)
        {

            display.Text = del(display.Text);
          
        }

        

        private void sqrt_click(object sender, EventArgs e)
        {
          
            display.Text =  Math.Sqrt(double.Parse(display.Text)).ToString();
            

        }

       private void xdel_click(object sender, EventArgs e)
        {
            display.Text = (1 / double.Parse(display.Text)).ToString() ;
        }
        private void pr_click(object sender, EventArgs e)
        {
            display.Text = (double.Parse(display.Text) * calc.first_number/100).ToString();
        }

       private void trig_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Text == "sin")
            {
                display.Text = (Math.Sin(double.Parse(display.Text)*Math.PI/180)).ToString();
            }
            if (btn.Text == "cos")
            {
                display.Text = (Math.Cos(double.Parse(display.Text) * Math.PI / 180)).ToString();
            }
            if (btn.Text == "tan")
            {
                display.Text = (Math.Tan(double.Parse(display.Text) * Math.PI / 180)).ToString();
            }
            if (btn.Text == "ctan")
            {
                display.Text = (1/Math.Tan(double.Parse(display.Text) * Math.PI / 180)).ToString();
            }




        }

       

        private void pow_click(object sender, EventArgs e)
        {
            display.Text = (Math.Pow(double.Parse(display.Text), 2)).ToString();
        }
        
        
    }
}
