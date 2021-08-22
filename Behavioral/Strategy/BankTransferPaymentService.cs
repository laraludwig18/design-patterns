using System;
using System.Linq;
using DesignPatterns.Structural.Facade;

namespace DesignPatterns.Behavioral.Strategy
{
    public class BankTransferPaymentService : IPayment
    {
        private readonly IBankTransferPaymentFacade _bankTransferPaymentFacade;

        public BankTransferPaymentService(IBankTransferPaymentFacade bankTransferPaymentFacade)
        {
            _bankTransferPaymentFacade = bankTransferPaymentFacade;
        }

        public Payment PerformPayment(Order order, Payment payment)
        {
            payment.Value = order.Products.Sum(p => p.Value);
            Console.WriteLine($"Starting bank transfer payment - Value R$ {payment.Value}");

            payment.TransferConfirmation = _bankTransferPaymentFacade.PerformPayment();
            payment.Status = "Paid by bank transfer";
            return payment;
        }
    }
}