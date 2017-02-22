using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Insert a word: ");
                string word = Console.ReadLine();
                bool result = Function(word);

                Console.Write("It Is " + result + " That The Word Is Palindrome. ");

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e + "\nError, please enter only letters without space.");
            }
        }

        static bool Function(string word)
        {
            bool match = false;
            int lenght = word.Length - 1;
            int lenghtToUse = word.Length - 1;
            int i;
            int counter = 0;
            int first = 0;
            int last = 0;
            bool palindrome = false;

            for (i = 0; i <= lenghtToUse; i++)
            {
                if (word[first++] == word[lenght - last++])
                {
                    match = true;
                    counter++;
                }
                else
                {
                    match = false;
                }
            }
            if (counter == word.Length)
            {
                palindrome = true;
            }
            else
            {
                palindrome = false;
            }
            
            return palindrome;
        }
    }
}
