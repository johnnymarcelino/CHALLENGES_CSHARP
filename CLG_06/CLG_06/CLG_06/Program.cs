using System;

namespace CLG_06 {
    internal class Program {
        static void Main(string[] args) {

            Retangulo width = new Retangulo();
            Retangulo height = new Retangulo();

            Console.WriteLine("Olá amigo. Vamos brincar de calcular!");
            Console.WriteLine();
            Console.WriteLine("Insira a altura e largura do triangulo:");
            width.Width = double.Parse(Console.ReadLine());
            Console.WriteLine();
            height.Height = double.Parse(Console.ReadLine());

            Console.WriteLine("A altura do retangulo é: " + height);
            Console.WriteLine("A largura do retangulo é: " + width);
        }
    }
}
