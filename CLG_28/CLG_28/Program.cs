using System;
using System.Linq;
using System.Collections.Generic;
using CLG_28.Entities;
using System.IO;
using System.Globalization;


/*
CHALLENGE 28:
Fazer um programa para ler um conjunto de produtos a partir de um
arquivo em formato .csv (suponha que exista pelo menos um produto).
Em seguida mostrar o preço médio dos produtos. Depois, mostrar os
nomes, em ordem decrescente, dos produtos que possuem preço
inferior ao preço médio. 
*/

namespace CLG_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Products> list = new List<Products>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split('\u002C');
                    string productName = fields[0];
                    double productPrice = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Products(productPrice, productName));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}



/*

using System;
using System.IO;
using System.Linq;

namespace ReadProductsFromFile
{
    class CLG_28
    {
        static void Main(string[] args)
        {
            // Path of the file to read
            string filePath = @"c:\tests\candidates.txt";

            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            // Create a list of products
            var products = lines.Select(x => new
            {
                Name = x.Split(',')[0],
                Price = Convert.ToDouble(x.Split(',')[1])
            }).ToList();

            // Calculate the average price
            var avgPrice = products.Average(x => x.Price);

            // Show the average price
            Console.WriteLine($"Average Price: {avgPrice}");

            // Get the products that have price lower than the average
            var lowPriceProducts = products.Where(x => x.Price < avgPrice)
            .OrderByDescending(x => x.Name);

            // Show the products
            Console.WriteLine("Products with a the average:");
            foreach (string product in products.OrderByDescending(x => x.Name))
                if (product.price < avgPrice)
                {
                    Console.WriteLine(product.Name);
                }
            Console.ReadKey();
        }
    }
}

class Product
{
    public string name;
    public double price;

    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
    }
}

*/