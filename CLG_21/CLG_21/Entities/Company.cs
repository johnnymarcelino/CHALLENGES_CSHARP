using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace CLG_21.Entities
{
    internal class Company : TaxPayers
    {
        public int NumberEmployees { get; set; }

        public Company()
        {
        }

        public Company(string name, double annualIncome, int numberEmployees) : base(name, annualIncome)
        {
            NumberEmployees = numberEmployees;
        }

        //public double TaxCom()
        //{
        //    return AnnualIncome - NumberEmployees;
        //}

    }
}
