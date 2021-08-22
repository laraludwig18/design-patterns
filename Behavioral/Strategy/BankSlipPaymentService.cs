using System;
using System.Linq;
using DesignPatterns.Structural.Facade;

namespace DesignPatterns.Behavioral.Strategy
{
    public class BankSlipPaymentService : IPayment
    {
        private readonly IBankSlipPaymentFacade _bankSlipPaymentFacade;

        public BankSlipPaymentService(IBankSlipPaymentFacade bankSlipPaymentFacade)
        {
            _bankSlipPaymentFacade = bankSlipPaymentFacade;
        }

        public Payment PerformPayment(Order order, Payment payment)
        {
            payment.Value = order.Products.Sum(p => p.Value);
            Console.WriteLine($"Starting bank slip payment - Valor R$ {payment.Value}");

            payment.BankSlipDigitableLine = _bankSlipPaymentFacade.GenerateBankSlip();
            payment.Status = "Waiting payment";
            return payment;
        }
    }
}