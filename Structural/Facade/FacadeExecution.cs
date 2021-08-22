using System;
using System.Collections.Generic;

namespace DesignPatterns.Structural.Facade
{
    public class FacadeExecution
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

            var payment = new Payment
            {
                CreditCard = "5555 2222 5555 9999"
            };

            var paymentService = new CreditCardPaymentService(new CreditCardPaymentFacade(new PayPalGateway(), new ConfigurationManager()));

            var paymentResult = paymentService.PerformPayment(order, payment);

            Console.WriteLine(paymentResult.Status);
        }
    }

}