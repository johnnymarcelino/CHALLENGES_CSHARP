using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;

namespace CLG_21.Entities
{
    internal class Company : TaxPayers
    {
        public int Workers { get; set; }


        public Company()
        {
        }

        public Company(int workers)
        {
            Workers = workers;
        }

        public double TaxTotalCom()
        {
            return Workers;
        }

    }
}
