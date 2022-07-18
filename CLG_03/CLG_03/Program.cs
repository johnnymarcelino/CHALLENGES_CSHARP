using System;
using System.Globalization;

namespace CLG_03 {
    internal class Program {
        static void Main(string[] args) {

            // Make a program to calculate the triangle area with the measures of the user.

            Console.WriteLine("Enter with the measures of the triangle X");
            Console.Write("Side A: ");
            double aX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Side B: ");
            double bX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Side C: ");
            double cX = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pX = (aX + bX + cX) / 2.0;
            double areaX = Math.Sqrt(pX * (pX - aX) * (pX - bX) * (pX - cX));

            Console.WriteLine("Enter with the measures of the triangle Y");
            Console.Write("Side A: ");
            double aY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Side B: ");
            double bY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Side C: ");
            double cY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double pY = (aY + bY + cY) / 2.0;
            double areaY = Math.Sqrt(pY * (pY - aY) * (pY - bY) * (pY - cY));

            Console.WriteLine($"Area of the triangle X is: {areaX.ToString("f4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area of the triangle Y is: {areaY.ToString("f4", CultureInfo.InvariantCulture)}");

            double bigTri;

            if (areaX > areaY) {
                bigTri = areaX;
                Console.WriteLine($"This is the triangle with the biggest area {bigTri.ToString("f4", CultureInfo.InvariantCulture)} triangle X");
            }
            else {
                bigTri = areaY;
                Console.WriteLine($"This is the triangle with the biggest area {bigTri.ToString("f4", CultureInfo.InvariantCulture)} triangle Y");
            }
        }
    }
}
