using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ExceptionHandling1
{
    class Program
    {
        static void Main(string[] args)
        {


           

            try
            {
                Console.WriteLine("Enter the First number");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Second number");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Operation");
                string operation = Console.ReadLine();
                Calculator calc = new Calculator();
                var res = calc.Calculate(num1,num2,operation);
                Console.WriteLine("Answer is " + res);
                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine();
                Console.WriteLine(ex.GetType());
                StreamWriter sr = new StreamWriter("Exception1.txt");
                sr.WriteLine(ex.Message);
                sr.Close();
            }



            Console.ReadLine();
        }
    }
}
