using System;
using System.Collections.Generic;
using System.Text;

namespace CLG_24.Service
{
    internal interface IOnlinePaymentService
    {
        double PaymentFree(double amount);
        double Interest(double amount, int months);
    }
}
