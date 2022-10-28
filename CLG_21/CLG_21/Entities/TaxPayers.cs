using System;
using System.Collections.Generic;
using System.Text;

namespace CLG_21.Entities
{
    internal class TaxPayers
    {
        //public double Taxpayers { get; set; }
        public string Name { get; set; }  // name
        public double AnnualIncome { get; set; }  // annual income
        public double TaxPaid { get; set; }  // total tax paid
        public double TaxCollected { get; set; }  // tax collected

        public TaxPayers()
        {
        }

        public TaxPayers(string name, double taxPaid, double taxCollected)
        {
            //Taxpayers = taxpayers;
            Name = name;
            TaxPaid = taxPaid;
            TaxCollected = taxCollected;
        }

        //public double TaxTotal()
        //{
        //    return TaxPaid;
        //}

    }
}
