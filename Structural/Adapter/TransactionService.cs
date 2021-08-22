namespace DesignPatterns.Structural.Adapter
{
    // Client
    public class TransactionService
    {
        private readonly ILogger _logger;

        public TransactionService(ILogger logger)
        {
            _logger = logger;
        }

        public void PerformTransaction()
        {
            _logger.Log("Transaction performed");
        }
    }
}