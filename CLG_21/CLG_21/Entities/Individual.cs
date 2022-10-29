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

        //public override string Tax()
        //{
        //    return base.Tax();
        //}
        //public double TaxInd(double tax)
        //{
        //    return AnnualIncome = HealthSpending - tax;
        //}


        //public double TaxIncomeInd()
        //{
        //    return base.TaxPaid;
        //}
    }
}
