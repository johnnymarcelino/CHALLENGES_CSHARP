using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CLG_10 {
    internal class BankOOP {

        public string Name { get; set; }
        public double Token { get; set; }
        public double _deposit { get; set; }

        public BankOOP() {
            _deposit = 0.0;
        }

        public void DepoYes(string startDep) {
            if (startDep.ToUpper() == "Y") {
                double d = 0.0;
                Console.Write("Enter with a value to deposit: ");
                d = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                _deposit += d;
            }
            else {
                Console.WriteLine("You have chosen don't realize a account deposit!");
            }
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
                _deposit -= wd + 5.00;
            }
            else {
                Console.WriteLine("You have chosen don't realize a cash withdraw!");
            }
        }

        public override string ToString() {
            return "Account Token: " + Token + ", Owner: " + Name + ", Balance: " + _deposit.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}