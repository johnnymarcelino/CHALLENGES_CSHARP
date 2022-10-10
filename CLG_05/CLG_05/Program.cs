using System;

namespace CLG_05 {
    internal class Program {
        static void Main(string[] args) {
            // Exercise: Fazer um programa para ler nome e salário de dois funcionários.
            // Depois, mostrar o salário médio dos funcionários.

            Funcionarios worker1, worker2;
            worker1 = new Funcionarios();
            worker2 = new Funcionarios();

            Console.Write("Enter with the name of the first worker: ");
            worker1.Name = Console.ReadLine();
            Console.Write("How much make the first worker: ");
            worker1.Salary1 = double.Parse(Console.ReadLine());
            Console.Write("Enter with the name of the second worker: ");
            worker2.Name = Console.ReadLine();
            Console.Write("How much make the second worker: ");
            worker2.Salary2 = double.Parse(Console.ReadLine());

            double aver = worker1.Average() + worker2.Average();
            // aver = worker2.Average();
            
            Console.WriteLine($"The avarege salary between the workers is: {aver}");

        }
    }
}
