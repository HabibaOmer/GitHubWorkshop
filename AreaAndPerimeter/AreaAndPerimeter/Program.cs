using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndPerimeter
{
    class Program
    {
        //1
        public static void Square()
        {
            Console.WriteLine("Enter the sidelength of the square: ");
            double sidelength = double.Parse(Console.ReadLine());
            double area = sidelength * sidelength;
            double perimeter = 4 * sidelength;
            Console.WriteLine($"The Area Of Square = {area} And The perimeter = {perimeter}.");
        }
        static void Main(string[] args)
        {
            Square();
            Console.ReadLine();
        }
    }
}
