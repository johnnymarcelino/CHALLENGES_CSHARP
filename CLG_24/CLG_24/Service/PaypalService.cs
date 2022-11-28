using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CLG_24.Service
{
    internal class PaypalService : IOnlinePaymentService
    {

        private const double FreePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double PaymentFree(double amount)
        {
            return amount * FreePercentage;
        }

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }
    }
}
