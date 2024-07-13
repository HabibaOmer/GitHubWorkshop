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
            Rectangle();
            Pyramid();
            Console.ReadLine();
        }
    }
}
