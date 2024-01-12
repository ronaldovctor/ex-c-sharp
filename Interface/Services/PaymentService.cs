using System;
using System.Collections.Generic;
using Interface.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services
{
    public class PaymentService
    {
        private readonly IPaymentService _paymentService;
        public PaymentService(IPaymentService payment)
        {
            _paymentService = payment;
        }
        
        public void ProcessContract(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;
            for(int i=1; i<=months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _paymentService.InterestPayment(basicQuota, i);
                double fullQuota = updatedQuota + _paymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}
