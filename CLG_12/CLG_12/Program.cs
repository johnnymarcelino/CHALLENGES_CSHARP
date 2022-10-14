using System;
using System.Collections.Generic;
using System.Globalization;


/*
CHALLENGE 12:
Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.

Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.

Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.
*/

namespace CLG_12 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("How many employees will be registered ? ");
            int quantityEmployee;
            quantityEmployee = int.Parse(Console.ReadLine());

            // declare a list with the type of the Class created reference
            List<Employees> listEmployees = new List<Employees>();

            for (int i = 1; i < quantityEmployee; i++) {
                Console.WriteLine("Employee #01");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listEmployees.Add(new Employees(id, name, salary ));
                Console.WriteLine();
            }

            Console.Write("Enter with the employee id that the salary will be increased: ");
            int searchId = int.Parse(Console.ReadLine());

            Employees idIncreased = listEmployees.Find(emp => emp.Id == searchId);
            if (idIncreased != null) {
                Console.Write("Enter with the employee id that the salary will be increased: ");
                double percentage = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                idIncreased.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This Id doesn't exit!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees:");
            foreach (Employees employee in listEmployees) {
                Console.WriteLine(employee);
            }
        }
    }
}
