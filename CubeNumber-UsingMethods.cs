using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        public static void Main(string[] args)
        {
            string input;

            Console.WriteLine("Insert a number: ");

            input = Console.ReadLine();
            int result = CubeNumber(int.Parse(input));

            Console.Write("The cube of {0} is {1}", input, result);
            Console.ReadKey();

        }

        public static int CubeNumber( int N)
        {
            return N * N * N; 
        }
    }
}
