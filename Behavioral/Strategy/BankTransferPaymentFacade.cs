using System;
using System.Linq;

namespace DesignPatterns.Behavioral.Strategy
{
    public class BankTransferPaymentFacade : IBankTransferPaymentFacade
    {
        public string PerformPayment()
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}