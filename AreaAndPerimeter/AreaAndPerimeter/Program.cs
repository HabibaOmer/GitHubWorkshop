﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndPerimeter
{
    class Program
    {
        //5
        public static void Trapezoid()
        {
            Console.WriteLine("Enter the base area of the trapezoid: ");
            double basearea = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the heigth of the trapezoid: ");
            double heigth = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the parallel of the trapezoid: ");
            double parallel = double.Parse(Console.ReadLine());
            double area = 0.5 * basearea * heigth;
            double perimeter = 2 * (basearea * parallel);
            Console.WriteLine($"The Area Of Trapezoid = {area} And The perimeter = {perimeter}.");
        }

        static void Main(string[] args)
        {
            Trapezoid();
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
