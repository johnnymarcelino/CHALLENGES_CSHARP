using System;
using System.Collections.Generic;
using System.Text;

namespace CLG_05 {
    internal class Funcionarios {
        public string Name;
        public double Salary1;
        public double Salary2;

        public double Average() {
            double aver;
            return aver = (Salary1 + Salary2) / 2;
        }
    }
}
