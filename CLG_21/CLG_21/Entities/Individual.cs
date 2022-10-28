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


        public Individual(string name, double taxPaid, double taxCollected, double income, double healthSpending) : base(name, taxPaid, taxCollected)
        {
            HealthSpending = healthSpending;
        }

        public double TaxTotalInd()
        {
            return HealthSpending;
        }

        //public double TaxIncomeInd()
        //{
        //    return base.TaxPaid;
        //}
    }
}
