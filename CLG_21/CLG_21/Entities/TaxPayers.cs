using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace CLG_21.Entities
{
    abstract class TaxPayers
    {
        public string Name { get; set; }  // name
        public double AnnualIncome { get; set; }  // annual income


        public TaxPayers()
        {
        }

        private protected TaxPayers(string name, double annualIncome)  // 
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        public abstract double Tax();
        
    }
}
