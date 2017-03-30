using System;

namespace Calculator
{
    internal class CalcClass
    {

        public double first_number;
        public double second_number = 0;
        public double result;
        public string operation;

        public void calculate()
        {
            switch (operation)
            {
                case "+":
                    result = second_number + first_number;
                    break;
                case "-":
                    result = first_number - second_number;
                    break;
                case "/":
                    result = first_number / second_number;
                    break;
                case "*":
                    result = first_number * second_number;
                    break;
                case "x^y":
                    result = Math.Pow(first_number, second_number);
                    break;
                case "x^(1/y)":
                    result = Math.Pow(first_number, 1 / second_number);
                    break;


            }
        }

        
    }
}