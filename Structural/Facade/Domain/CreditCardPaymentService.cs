using System;
using System.Linq;

namespace DesignPatterns.Structural.Facade
{
    public class CreditCardPaymentService : IPayment
    {
        private readonly ICreditCardPaymentFacade _creditCardPaymentFacade;

        public CreditCardPaymentService(ICreditCardPaymentFacade creditCardPaymentFacade)
        {
            _creditCardPaymentFacade = creditCardPaymentFacade;
        }

        public Payment PerformPayment(Order order, Payment payment)
        {
            payment.Value = order.Products.Sum(p => p.Value);
            Console.WriteLine("Starting credit card payment - Value R$ " + payment.Value);

            if (_creditCardPaymentFacade.PerformPayment(order, payment))
            {
                payment.Status = "Credit card payment";
                return payment;
            }

            payment.Status = "Credit card refused!";
            return payment;
        }
    }
}