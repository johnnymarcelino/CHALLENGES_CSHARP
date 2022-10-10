using System;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

/*
CHALLENGE 06:
Fazer um programa para ler os valores da largura e altura de um retângulo. 
Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal.
Usar uma classe como mostrado no projeto ao lado.
*/

namespace CLG_06 {
    internal class Program {
        static void Main(string[] args) {

            Retangulo dim = new Retangulo();

            Console.WriteLine("Hello guys. Let's play calculating!");
            Console.WriteLine();
            Console.WriteLine("Enter with width and height of retangle, respectively:");
            dim.Width = double.Parse(Console.ReadLine());
            dim.Height = double.Parse(Console.ReadLine());

            Console.WriteLine("The retangle's area is: " + dim.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("The retangle's diagonal is: " + dim.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("The retangle's perimeter is: " + dim.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
