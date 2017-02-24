using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the number of elements that are going to be entered below.");
                int firstAnswer = int.Parse(Console.ReadLine());
                int result = Bigger(firstAnswer);

                Console.WriteLine("\nThe biggest number is: " + result);
                Console.ReadKey();
            }

            catch (Exception e)
            {
                Console.WriteLine("Error: "+ e + "\nPlease enter whole numbers only");
            }
            Console.ReadKey();
        }

        public static int Bigger (int answer)
        { 
            int[] numbers = new int[answer];
            int w = 0;

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                Console.WriteLine("Element number: "   );
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] >= w)
                {
                    w = numbers[i];
                }               
            }
            return w;

        }
    }
}
