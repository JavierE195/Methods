using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Insert the radius of the circle in centimeters: ");
            double r = double.Parse(Console.ReadLine());
            double diameterResult = Diameter(r);

            double circumferenceResult = (Circumference(diameterResult));

            double areaResult = Area(r);

            Console.Write("The diameter of the circle is " + diameterResult +"cm");
            Console.Write("\nThe circumference of the circle is " + circumferenceResult + "cm");
            Console.Write("\nThe area of the circle is " + areaResult + "cm square");
            Console.ReadKey();
        }
        public static double Diameter(double radius)
        {
            return radius * 2;
        }

        public static double Circumference(double diameter)
        {
            return diameter * 3.14159;
        }

        public static double Area(double radius)
        {
            return radius * radius * 3.14159;
        }
    }
}
