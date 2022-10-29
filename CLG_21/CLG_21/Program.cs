using System;
using CLG_21.Entities;
using System.Globalization;
using System.Collections.Generic;

/*

CHALLENGE 21:
Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais
podem ser pessoa física ou pessoa jurídica, e depois mostrar o valor do imposto pago por cada um,
bem como o total de imposto arrecadado.

Os dados de pessoa física são: nome, renda anual e gastos com saúde. Os dados de pessoa jurídica
são nome, renda anual e número de funcionários. As regras para cálculo de imposto são as
seguintes:

Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. Pessoas com
renda de 20000.00 em diante pagam 25% de imposto. Se a pessoa teve gastos com saúde, 50%
destes gastos são abatidos no imposto.

Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto
fica: (50000 * 25%) - (2000 * 50%) = 11500.00
Pessoa jurídica: pessoas jurídicas pagam 16% de imposto. Porém, se a empresa possuir mais de 10
funcionários, ela paga 14% de imposto.
Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica:
400000 * 14% = 56000.00 

*/

namespace CLG_21
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter with the number of taxpayers: ");
            int taxpayers = int.Parse(Console.ReadLine());

            List<TaxPayers> taxpayersList = new List<TaxPayers>();

            for (int i = 1; i <= taxpayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c) ? ");
                char indCom = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (indCom == 'i')
                {
                    Console.Write("Health Spending: ");
                    double healthSpending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    TaxPayers taxIndividual = new Individual(name, annualIncome, healthSpending);
                    taxpayersList.Add(taxIndividual);
                    Console.WriteLine();
                }
                else if (indCom == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    TaxPayers taxCompany = new Company(name, annualIncome, numberEmployees);
                    taxpayersList.Add(taxCompany);
                    Console.WriteLine();
                }
            }

            double sum = 0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayers taxPayers in taxpayersList)
            {
                double tax = taxPayers.Tax();
                Console.WriteLine(taxPayers.Name + " $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
