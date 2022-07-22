using System;
using System.Collections.Generic;
using System.Text;

namespace CLG_04 {
    internal class DataWorkers {
        public string Name;
        public double Age1;
        public double Age2;

        // public double Age2;

        public double Bigger() {
            double older1;
            double older2;

            // bigAge = Age2;
            if (Age1 > Age2) {
                return older1 = Age1;
            }
            else {
                return older2 = Age2;
            }
        }
    }
}
