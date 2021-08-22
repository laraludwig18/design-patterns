namespace DesignPatterns.Structural.Facade
{
    public interface ICreditCardPaymentFacade
    {
        bool PerformPayment(Order oder, Payment payment);
    }
}