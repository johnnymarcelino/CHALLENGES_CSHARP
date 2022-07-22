using System;

namespace CLG_04 {
    internal class Program {
        static void Main(string[] args) {

            // EXERCÍCIO 01: Fazer um programa para ler os dados de duas pessoas,
            // depois mostrar o nome da pessoa mais velha.

            DataWorkers per1, per2;

            per1 = new DataWorkers();
            per2 = new DataWorkers();

            // double biggest = 0;

            // DataWorkers worker = new DataWorkers();

            Console.Write("Enter with the name of the first person: ");
            per1.Name = Console.ReadLine();
            Console.Write("Enter with the name of the second person: ");
            per2.Name = Console.ReadLine();

            Console.WriteLine("How old are the fisrt person? ");
            per1.Age1 = double.Parse(Console.ReadLine());
            Console.WriteLine("How old are the second person? ");
            per2.Age1 = double.Parse(Console.ReadLine());

            double older1 = per1.Bigger();
            double older2 = per2.Bigger();

            Console.WriteLine($"Your name is {per1.Name} and you are {per1.Age1}");
            Console.WriteLine($"YOur name is {per2.Name} and you are {per2.Age1}");

            if (per1.Age1 > per2.Age1) {
                // biggest = per1.Age1;
                Console.WriteLine($"Then the older is {per1.Name} with {older1}");
            }
            else {
                //biggest = per2.Age1;
                Console.WriteLine($"Then the older is {per2.Name} with {older2}");
            }

        }
    }
}
