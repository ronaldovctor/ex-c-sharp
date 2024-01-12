using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Services
{
    public class PaypalService : IPaymentService
    {
        private double MonthlyInterest = 0.01;
        private double Fee = 0.02;
        public double InterestPayment(double amount, int months)
        {
            double result = (amount * months) * MonthlyInterest;  
            return result;
        }

        public double PaymentFee(double amount)
        {
            double result = amount * Fee;
            return result;
        }
    }
}
