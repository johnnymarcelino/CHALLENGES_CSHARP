using System;

namespace CLG_10 {
    internal class Program {
        static void Main(string[] args) {

            BankOOP owner = new BankOOP();

            Console.Write("Enter with the number of your account: ");
            owner.Token = double.Parse(Console.ReadLine());

            Console.Write("Enter with the name of the account owner: ");
            owner.Name = Console.ReadLine();

            Console.Write("Will be deposit account at the beginning ? (y / n) ");
            string depoYesNot = Console.ReadLine();
            owner.DepoYes(depoYesNot);
            //owner._deposit = Console.ReadLine();

            Console.WriteLine($"Account data:");
            Console.WriteLine($"{owner}");

            Console.WriteLine("Would you like to deposit any more ? (y / n)");
            depoYesNot = Console.ReadLine();
            owner.DepoYes(depoYesNot);

            Console.WriteLine($"Account data updated:");
            Console.WriteLine($"{owner}");
            
            Console.WriteLine($"Would you like to do a withdraw ? (y / n)");
            string withdrawYesNot = Console.ReadLine();
            owner.Withdraw(withdrawYesNot);

            Console.WriteLine($"Account data updated:");
            Console.WriteLine($"{owner}");


        }
    }
}
