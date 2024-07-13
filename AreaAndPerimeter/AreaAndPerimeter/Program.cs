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
            Console.WriteLine("---------------------Enhance Trapezoid Function-------------------");
            Console.WriteLine("-Enter the base area of the trapezoid: ");
            double basearea = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("-Enter the heigth of the trapezoid: ");
            double heigth = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("-Enter the parallel of the trapezoid: ");
            double parallel = double.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");
            double area = 0.5 * basearea * heigth;
            double perimeter = 2 * (basearea * parallel);
            Console.WriteLine($"**************The Area Of Trapezoid = {area} And The perimeter = {perimeter}.**************");
        }
        static void Main(string[] args)
        {
            //5
            Trapezoid();
            Console.ReadLine();
        }
    }
}
