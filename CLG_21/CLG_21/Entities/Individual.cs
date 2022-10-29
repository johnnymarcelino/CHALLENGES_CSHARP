using System;
using System.Collections.Generic;
using System.Text;

namespace CLG_21.Entities
{
    internal class Individual : TaxPayers
    {
        public double HealthSpending { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double annualIncome, double healthSpending) : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double Tax()
        {
            if(AnnualIncome < 20000.00)
            {
                return AnnualIncome * .15 - HealthSpending * .50;
            }
            else
            {
                return AnnualIncome * .25 - HealthSpending * .5;
            }
        }
    }
}
