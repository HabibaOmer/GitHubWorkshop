using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndPerimeter
{
    class Program
    {
        //3
        public static void Rectangle()
        {
            Console.WriteLine("Enter the length of the square: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of the square: ");
            double width = double.Parse(Console.ReadLine());
            double area = length * width;
            double perimeter = 2 * (length * width);
            Console.WriteLine($"The Area Of Rectangle = {area} And The perimeter = {perimeter}.");
        }

        static void Main(string[] args)
        {
            Rectangle();
            Console.ReadLine();
        }
    }
}
