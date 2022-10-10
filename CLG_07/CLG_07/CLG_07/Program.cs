using System;
using System.Globalization;

/*
CHALLENGE 07:
Fazer um programa para ler os dados de um funcionário (nome,
salário bruto e imposto). Em seguida, mostrar os dados do
funcionário (nome e salário líquido). Em seguida, aumentar o salário
do funcionário com base em uma porcentagem dada (somente o
salário bruto é afetado pela porcentagem) e mostrar novamente os
dados do funcionário. Use a classe projetada abaixo
*/


namespace CLG_07 {
    internal class Program {
        static void Main(string[] args) {

            Worker worker = new Worker();

            Console.Write("Nome: ");
            worker.Name = Console.ReadLine();
            Console.Write("Gross Salary: ");
            worker.GrossSalary = double.Parse(Console.ReadLine());
            Console.Write("Taxes: ");
            worker.Taxes = double.Parse(Console.ReadLine());

            Console.WriteLine($"Worker: {worker}");

            Console.Write("Enter with the percentage to increse the salary: ");
            double salaryIncrese = double.Parse(Console.ReadLine());
            worker.SalaryIncrese(salaryIncrese);

            Console.WriteLine($"Datas of salary updated: {worker}");
        }
    }
}
