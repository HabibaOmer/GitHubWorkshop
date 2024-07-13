using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndPerimeter
{
    class Program
    {
        //4
        public static void Pyramid()
        {
            Console.WriteLine("The volum of the Pyramid: ");
            Console.WriteLine("Enter the base area of the Pyramid: ");
            double baseArea = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the heigth of the square: ");
            double heigth = double.Parse(Console.ReadLine());
            double volum = (1.0 / 3.0) * baseArea * heigth;
            Console.WriteLine($"The volum Of Pyramid = {volum}");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("The surface area of the Pyramid: ");
            Console.WriteLine("Enter the base area of the Pyramid: ");
            double baseArea2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the slant heigth of the square: ");
            double slantHeigth = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of sides of the Pyramid: ");
            double numberOfSides = double.Parse(Console.ReadLine());

            double surfaceArea = baseArea2 + (numberOfSides * 0.5 * baseArea2 * slantHeigth);

            Console.WriteLine($"The surface area of Pyramid= {surfaceArea}.");
        }

        static void Main(string[] args)
        {
            Pyramid();
            Console.ReadLine();
        }
    }
}
