using System;

namespace DesignPatterns.Behavioral.Observer
{
    // Concrete Observer
    internal class Observable : IObservable
    {
        public Observable(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Notify(Investment investment)
        {
            Console.WriteLine("Notificando {0} que {1} " +
                              "teve preço alterado para {2:C}", Name, investment.Symbol, investment.Value);
        }


    }
}