using CLG_24.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CLG_24.Service
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuora = basicQuota + _onlinePaymentService.Interest(basicQuota, i);
                double fullQuota = updateQuora + _onlinePaymentService.PaymentFree(updateQuora);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
