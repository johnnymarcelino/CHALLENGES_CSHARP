using System;
using System.Collections.Generic;
using System.Text;

namespace CLG_28.Entities
{
    internal class Products
    {
        public double Price { get; set; }
        public string Name { get; set; }

        public Products(double price, string name)
        {
            Price = price;
            Name = name;
        }

    }
}
