using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CLG_10 {
    internal class BankOOP {

        public string Holder { get; private set; }
        public int Token { get; private set; }
        public double _balance { get; private set; }


        public BankOOP(string holder, int token) {
            Holder = holder;
            Token = token;
        }

        public BankOOP(string holder, int token, double deposit) : this(holder, token){
            DepoYesNot(deposit);
        }


        public void DepoYesNot(double startDep) {
            _balance += startDep;
            ToString();
            /*if (startDep == 'y' || startDep == 'Y') {
                double d = 0.0;
                Console.Write("Enter with a value to deposit: ");
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                _deposit += d;
                _deposit = 500.00;
                ToString();
            }
            else {
                double d = 0.0;
                Console.Write("Enter with a value to deposit: ");
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                _deposit += d;
                Console.WriteLine("You have chosen don't realize a account deposit!");
                _balance = 0.0;
                ToString();
                Console.WriteLine($"{}");
            }
            */
        }

        //public void DepoNo(string startDep) {
        //    if (startDep == )

        //public double DepoStart() {
        //    double d = 0.0;
        //    Console.Write("Enter with a value to deposit: ");
        //    d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //    return _deposit += d;
        //    //double depoStart = double.Parse(Console.ReadLine());
        //}

        public void Withdraw(string withdraw) {
            if (withdraw.ToUpper() == "Y") {
                double wd = 0.0;
                Console.WriteLine("Warning! If you realize a withdraw, you have a tax of $ 5.00 dollars.");
                Console.Write("Enter with a value to do a withdraw: ");
                wd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                _balance += wd - 5.00;
            }
            else {
                Console.WriteLine("You have chosen don't realize a cash withdraw!");
            }
        }

        public override string ToString() {
            return "Account Token: " + Token + ", Owner: " + Holder + ", Balance: $ " + _balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}