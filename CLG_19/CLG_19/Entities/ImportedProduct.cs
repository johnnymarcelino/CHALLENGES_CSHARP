using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CLG_19.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + "(Customs fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";

        }

        public virtual double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
