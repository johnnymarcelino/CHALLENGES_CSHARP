using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CLG_21.Entities
{
    internal class TaxPayers
    {
        //public double Taxpayers { get; set; }
        public string Name { get; set; }  // name
        public double AnnualIncome { get; set; }  // annual income

        //public double TaxPaid { get; set; }  // total tax paid
        //public double TaxCollected { get; set; }  // tax collected

        public TaxPayers()
        {
        }

        public TaxPayers(string name, double annualIncome)
        {
            //Taxpayers = taxpayers;
            Name = name;
            AnnualIncome = annualIncome;
            //TaxPaid = taxPaid;
            //TaxCollected = taxCollected;
        }

        public string Tax()
        {
            return Name + " $ " + AnnualIncome.ToString("F2", CultureInfo.InvariantCulture);
        }
        //public string TaxOne()
        //{
        //    StringBuilder all = new StringBuilder();
        //    all.AppendLine();
        //}
    }
}
