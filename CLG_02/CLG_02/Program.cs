using System;
using System.Globalization;

namespace CLG_02 {
    internal class Program {
        static void Main(string[] args) {

            // Challenge-02: Make a program to perform the following user interactionr,
            // reading the values highlighted in red and then displaying the datas on the screen.
            

            // Comands Write, Read, string, double, int, Parse and CultInfo.InvCult

            Console.Write("What is your name ? ");
            string name = Console.ReadLine();
            Console.Write("How many bedrooms are there in your house ? ");
            int bedroom = int.Parse(Console.ReadLine());
            Console.Write("Enter with any price of a product: ");
            double priceProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter with your last name, age and height (on the same line): ");
            string[] data = Console.ReadLine().Split(" ");
            string lastName = data[0];
            int age = int.Parse(data[1]);
            double tall = double.Parse(data[2]);

            Console.WriteLine($"Your name is: {name}");
            Console.WriteLine($"You have {bedroom} bedrooms in your house.");
            Console.WriteLine($"The price of the product that you entered was: {priceProd.ToString("f2", CultureInfo.InvariantCulture)} dollars");
            Console.WriteLine($"Your last name is: {lastName}");            
            Console.WriteLine($"You are {age} years old");            
            Console.WriteLine($"You are {tall.ToString("f2", CultureInfo.InvariantCulture)} meters tall");
        }
    }
}
