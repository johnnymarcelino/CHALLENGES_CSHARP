using CLG_19.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;


/*
CHALLENGE 19:

Fazer um programa para ler os dados de N produtos (N fornecido pelo usuário). Ao final,
mostrar a etiqueta de preço de cada produto na mesma ordem em que foram digitados.

Todo produto possui nome e preço. Produtos importados possuem uma taxa de alfândega, e
produtos usados possuem data de fabricação. Estes dados específicos devem ser acrescentados 
na etiqueta de preço conforme exemplo (próxima página). Para produtos importados, a taxa e 
alfândega deve ser acrescentada ao preço final do produto.

*/

namespace CLG_19
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> listProducts = new List<Product>();

            Console.Write("Enter the number of product: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Commom, Used or Imported (C/U/I) ? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Price:");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listProducts.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                    if (type == 'u')
                {
                    Console.WriteLine("Manufacture Date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    //DateTime manufactureDate = DateTime.Parse.Console.ReadLine(new <UsedProduct> ("dd/mm/yyyy"));
                    listProducts.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    listProducts.Add(new Product(name, price));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in listProducts)
            {
                Console.WriteLine(product.PriceTag());
                //Console.WriteLine($"{product.Name}: $ {product.Price}");
            }
        }
    }
}
