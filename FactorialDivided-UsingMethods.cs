using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Insert a number: ");
                double num = int.Parse(Console.ReadLine());

                double result = Formula(num, 1, 1, 0);
                Console.WriteLine("The factorial of the number divided by itself is " + result);
                Console.ReadKey();
            }
            catch (Exception )
            {
                Console.WriteLine("Error ");
            }
            Console.ReadKey();
        }
        static double Formula(double num, int i = 1, int factorial = 1,  double result = 0)
        {
            try
            {
                for (i = 1; i <= num; i++)
                {
                    factorial = factorial * i;
                    result = factorial / num;
                }
            }
            catch (Exception e) when (result == 0)
            {
                Console.Write( "{0} Error", e);
            }
            return result;
        }
    }
}
