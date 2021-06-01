using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandling1
{
    class Calculator
    {

        public double Calculate(int num1, int num2,string operation)
        {
            if (operation == "/")
                return Divide(num1, num2);
            
            else
            {
                throw new ArgumentException("Unknown Operation");
            }
           
        }

        public double Divide(int Num1, int Num2)
        {
            if (Num2 == 0)
                throw new ArithmeticException("Invalid Operation! Divisor cannot be zero");
            else if (Num1 < Num2)
            {
                //Custom Exception
                throw new InvalidNumberException("Invalid  first Number ");
            }
            return (double) Num1 / Num2;
        }
    }


}
