using DesignPatterns.Structural.Facade;

namespace DesignPatterns.Behavioral.Strategy
{
    public class OrderService
    {
        private readonly IPayment _payment;
        
        public OrderService(IPayment payment)
        {
            _payment = payment;
        }

        public Payment PerformPayment(Order order, Payment payment)
        {
            return _payment.PerformPayment(order, payment);
        }
    }
}