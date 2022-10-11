using System;
using System.Globalization;

/*
CHALLANGE 09:
Fazer um programa para ler os valores da largura e altura de um retângulo. Em
seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe
como mostrado no projeto ao lado. 
*/

namespace CLG_09 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("What is it the price of the dollar: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("How much do you intend to buy at the mall: ");
            double quantity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = CurrencyConverter.DollarToReal(price, quantity);

            Console.WriteLine($"Value to pay in real = " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
