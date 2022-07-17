using System;
using System.Globalization;

namespace CLG_01 {
    internal class Program {
        static void Main(string[] args) {
            // Challenge 01 - 

            // Variable Declaration
            string product1 = "Computer";
            string product2 = "Office Table";

            byte age = 30;
            int code = 5290;
            char gene = 'M';

            double price = 2100.5;
            double price1 = 650.50;
            double mesure = 53.234567;

            // Print results
            Console.WriteLine("Products: ");
            Console.WriteLine($"{product1} who the price is: {price}");
            Console.WriteLine($"{product2} who the price is: {price1}");
            Console.WriteLine($"Registry: {age} years old, code {code} and the gene: {gene}");

            Console.WriteLine($"Mesure with eight decimal places: {mesure:f8}");
            Console.WriteLine($"Rounded to three decimal places: {mesure:f3}");
            Console.WriteLine("Separete decimal palces invariant culture " + mesure.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
