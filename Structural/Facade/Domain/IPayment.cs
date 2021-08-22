namespace DesignPatterns.Structural.Facade
{
    public interface IPayment
    {
        Payment PerformPayment(Order order, Payment payment);
    }
}