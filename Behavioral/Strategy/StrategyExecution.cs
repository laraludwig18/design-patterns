using System;
using System.Collections.Generic;
using DesignPatterns.Structural.Facade;

namespace DesignPatterns.Behavioral.Strategy
{
    public class StrategyExecution
    {
        public static void Execute()
        {
             var products = new List<Product>
            {
                new Product{Name = "Tenis Adidas", Value = new Random().Next(500)},
                new Product{Name = "Camisa Boliche", Value = new Random().Next(500)},
                new Product{Name = "Raquete Tenis", Value = new Random().Next(500)}
            };

            var order = new Order
            {
                Id = Guid.NewGuid(),
                Products = products
            };

            var creditCardPaymentMethod = new Payment
            {
                PaymentMethod = PaymentMethod.CreditCard,
                CreditCard = "5555 2222 5555 9999"
            };

            var bankSlipPaymentMethod = new Payment
            {
                PaymentMethod = PaymentMethod.BankSlip
            };

            var bankTransferPaymentMethod = new Payment
            {
                PaymentMethod = PaymentMethod.BankTransfer,
                CreditCard = "5555 2222 5555 9999"
            };

            #region Easy way

            var creditCardOrder = new OrderService(
                                   new CreditCardPaymentService(
                                   new CreditCardPaymentFacade(
                                   new PayPalGateway(),
                                   new ConfigurationManager())));
            var creditCardPayment = creditCardOrder.PerformPayment(order, creditCardPaymentMethod);
            Console.WriteLine(creditCardPayment.Status);

            Console.WriteLine("-------------------------------------------------------");

            var bankSlipOrder = new OrderService(
                                   new BankSlipPaymentService(
                                   new BankSlipPaymentFacade()));

            var bankSlipPayment = bankSlipOrder.PerformPayment(order, bankSlipPaymentMethod);
            Console.WriteLine(bankSlipPayment.Status);

            Console.WriteLine("-------------------------------------------------------");

            var bankTransferOrder = new OrderService(
                                          new BankTransferPaymentService(
                                          new BankTransferPaymentFacade()));

            var bankTransferPayment = bankTransferOrder.PerformPayment(order, bankTransferPaymentMethod);
            Console.WriteLine(bankTransferPayment.Status);

            Console.WriteLine("-------------------------------------------------------");

            #endregion

            #region Elegant way

            var creditCardOrder2 = new OrderService(PaymentFactory.CreatePayment(creditCardPaymentMethod.PaymentMethod));
            var creditCardPayment2 = creditCardOrder2.PerformPayment(order, creditCardPaymentMethod);
            Console.WriteLine(creditCardPayment2.Status);

            Console.WriteLine("-------------------------------------------------------");

            var bankSlipOrder2 = new OrderService(PaymentFactory.CreatePayment(bankSlipPaymentMethod.PaymentMethod));
            var bankSlipPayment2 = bankSlipOrder2.PerformPayment(order, bankSlipPaymentMethod);
            Console.WriteLine(bankSlipPayment2.Status);

            Console.WriteLine("-------------------------------------------------------");

            var bankTransferOrder2 = new OrderService(PaymentFactory.CreatePayment(bankTransferPaymentMethod.PaymentMethod));
            var bankTransferPayment2 = bankTransferOrder2.PerformPayment(order, bankTransferPaymentMethod);
            Console.WriteLine(bankTransferPayment2.Status);

            #endregion
        }
    }
}