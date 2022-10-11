using System;
using System.Collections.Generic;
using System.Text;

namespace CLG_09 {
    internal class CurrencyConverter {

        public static double Iof = 6.0;

        public static double DollarToReal(double quantity, double price) { 
            double total = quantity * price;
            return total + total * Iof / 100.0;
        }
    }
}
