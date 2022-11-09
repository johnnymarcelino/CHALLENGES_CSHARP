using System;
using CLG_22.Entities;
using System.Globalization;

/*

CHALLENGE 22:

Fazer um programa para ler os dados de uma conta bancária e depois realizar um
saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
saque da conta.

*/


namespace CLG_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Enter with account number:");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial Balance: $ ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: $ ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Account acc = new Account(number, holder, balance, withdrawLimit);

            Console.WriteLine();

            Console.Write("Enter with the amount for withdraw: $ ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                acc.Withdraw(amount);
                Console.WriteLine("New Balance: $ " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Withdraw error: " + ex.Message);
            }
        }
    }
}
