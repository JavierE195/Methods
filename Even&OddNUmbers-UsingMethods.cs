using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a number: ");
            int number = int.Parse(Console.ReadLine());
            bool state = false;

            bool result = Number(state, number);

            Console.Write("It is "+ result + " that the number is even.");
            Console.ReadKey();
        }
        static bool Number(bool even, int number)
        {
            number =  number % 2;

            if (number > 0)
            {
                even = false;
            }
            else
            {
                even = true;
            }

            return even;
        }
    }
}
