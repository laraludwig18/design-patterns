namespace DesignPatterns.Behavioral.Observer
{

    // Concrete Subject
    public class PapelBovespa : Investment
    {
        public PapelBovespa(string symbol, decimal price)
            : base(symbol, price)
        {
        }
    }
}