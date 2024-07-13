using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndPerimeter
{
    class Program
    {
        //2
        public static void Triangle()
        {
            Console.WriteLine("The Area Of Triangle: ");
            Console.WriteLine("Enter the baselength of the triangle: ");
            double baselength = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the heigth of the triangle: ");
            double heigth = double.Parse(Console.ReadLine());
            double area = 0.5 * baselength * heigth;
            Console.WriteLine($"The Area Of Triangle = {area}.");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("The perimeter Of Triangle: ");
            Console.WriteLine("Enter the length of the first side of the triangle: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the secound side of the triangle: ");
            double side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the third side of the triangle: ");
            double side3 = double.Parse(Console.ReadLine());
            double perimeter = side1 + side2 + side3;
            Console.WriteLine($"The perimeter Of Triangle = {perimeter}.");
        }
        static void Main(string[] args)
        {
            Triangle();
            Console.ReadLine();
        }
    }
}
