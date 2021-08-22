using System;
using DesignPatterns.Structural.Facade;

namespace DesignPatterns.Behavioral.Strategy
{
    public class PaymentFactory
    {
        public static IPayment CreatePayment(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    return new CreditCardPaymentService(
                               new CreditCardPaymentFacade(
                               new PayPalGateway(),
                               new ConfigurationManager()));

                case PaymentMethod.BankSlip:
                    return new BankSlipPaymentService(new BankSlipPaymentFacade());

                case PaymentMethod.BankTransfer:
                    return new BankTransferPaymentService(new BankTransferPaymentFacade());

                default:
                    throw new ApplicationException("Unknown payment method");
            }
        }
    }
}