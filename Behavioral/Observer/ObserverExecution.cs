using System;

namespace DesignPatterns.Behavioral.Observer
{
    public static class ObserverExecution
    {
        public static void Execute()
        {
            var joao = new Observable("João");
            var eduardo = new Observable("Eduardo");
            var bill = new Observable("Bill");

            var amazon = new PapelBovespa("Amazon", NextDecimal());
            var microsoft = new PapelBovespa("Microsoft", NextDecimal());
            
            amazon.Subscribe(joao);
            amazon.Subscribe(eduardo);

            microsoft.Subscribe(eduardo);
            microsoft.Subscribe(bill);

            Console.WriteLine("");
            Console.WriteLine("------------------");
            Console.WriteLine("");

            for (int i = 0; i < 5; i++)
            {
                amazon.Value = NextDecimal();
                microsoft.Value = NextDecimal();

                if (i == 1)
                {
                    amazon.UnSubscribe(eduardo);
                }
            }
        }

        public static decimal NextDecimal()
        {
            var random = new Random();
            var r = random.Next(141421, 314160);
           return r / (decimal) 100000.00;
        }
    }
}