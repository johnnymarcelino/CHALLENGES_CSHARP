using System;


namespace CLG_08 {
    internal class Student {
        public string Name;
        public double Grade1, Grade2, Grade3, GradeTotal;

        public double SumGrades() {
            //return GradeTotal = ((Grade1 + (Grade1 * (30 / 100))) + (Grade2 + (Grade2 * (35 / 100))) + (Grade3 + (Grade3 * (35 / 100)))) / 3; => lógica direta, somente utilizando uma função.
            return Grade1 + Grade2 + Grade3;
        }

        public bool Approved() {
            if (SumGrades() >= 60.0) {
                return true;
            }
            else {
                return false;
            }
        }

        public double TotalMissing() {
            if (Approved()) {
                return 0.0;
            }
            else { 
                return 60.0 - SumGrades(); 
            }
        }
    }
}
