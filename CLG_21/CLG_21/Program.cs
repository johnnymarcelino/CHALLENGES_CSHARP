using CLG_21.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.Linq;

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
            double taxAnnual = 0.0;
            List<TaxPayers> taxpayersList = new List<TaxPayers>();

            for (int i = 1; i <= taxpayers; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c) ? ");
                char indCom = char.Parse(Console.ReadLine());

                if (indCom == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Annual Income: ");
                    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health Expenditures: ");
                    double healthEspending = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (annualIncome > 20000 && healthEspending > 0)
                    {
                        taxAnnual = annualIncome * .25 - healthEspending * .50;
                        //taxAnnual = taxAnnual + (healthEspending * .50);
                    }
                    else if (annualIncome < 20000.00)
                    {
                        taxAnnual = annualIncome - (annualIncome * .15);
                    }
                    //else if(healthEspending )
                    TaxPayers taxIndividual = new Individual(name, taxAnnual, healthEspending);
                    taxpayersList.Add(taxIndividual);
                    Console.WriteLine();
                }
                else if (indCom == 'c')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Annual Income: ");
                    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numberEmployees = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    if (numberEmployees > 10)
                    {
                        taxAnnual = annualIncome * .14;
                    }
                    else
                    {
                        taxAnnual = annualIncome - (annualIncome * .16);
                    }
                    TaxPayers taxCompany = new Company(name, taxAnnual, numberEmployees);
                    taxpayersList.Add(taxCompany);
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (TaxPayers taxPayers in taxpayersList)
            {
                //TaxPayers tax = new TaxPayers();
                Console.WriteLine(taxPayers.Name + " $ " + taxPayers.AnnualIncome.ToString("F2", CultureInfo.InvariantCulture));
            }
            
            //foreach (Company taxPayers in taxpayersList)
            //{
            //    taxPayers.AnnualIncome(taxPayers);
            //}
        }
    }
}
