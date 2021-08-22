namespace DesignPatterns.Structural.Facade
{
    public class Payment
    {
        public string Status { get; set; }
        public decimal Value { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string CreditCard { get; set; }
        public string BankSlipDigitableLine { get; set; }
        public string TransferConfirmation { get; set; }
    }
}