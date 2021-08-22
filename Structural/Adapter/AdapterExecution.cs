namespace DesignPatterns.Structural.Adapter
{
    public class AdapterExecution
    {
        public static void Execute()
        {
            var transactionServiceDefaultLogger = new TransactionService(new Logger());
            transactionServiceDefaultLogger.PerformTransaction();

            var transactionServiceCustomLogger = new TransactionService(new LogAdapter(new LogNetMasterService()));
            transactionServiceCustomLogger.PerformTransaction();
        }
    }
}