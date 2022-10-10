using System;
using System.Globalization;

namespace CLG_07 {
    internal class Worker {

        public string Name;
        public double GrossSalary;
        public double Taxes;

        public double NetSalary() {
            return GrossSalary - Taxes;
        }

        public void SalaryIncrese(double increse) {
            GrossSalary += ((GrossSalary * increse) / 100);
        }

        public override string ToString() { 
            return Name + ", $ " + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
