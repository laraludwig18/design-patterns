using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioral.Observer
{
    // Subject
    public abstract class Investment
    {
        private decimal _value;
        private readonly List<IObservable> _observables = new List<IObservable>();

        protected Investment(string symbol, decimal value)
        {
            Symbol = symbol;
            _value = value;
        }

        public string Symbol { get; }
        public decimal Value
        {
            get => _value;
            set
            {
                if (_value == value) return;

                _value = value;
                Notify();
            }
        }


        public void Subscribe(IObservable observable)
        {
            _observables.Add(observable);
            Console.WriteLine($"Notificando que {observable.Name} está recebendo atualizações de {Symbol}");
        }

        public void UnSubscribe(IObservable observable)
        {
            _observables.Remove(observable);
            Console.WriteLine($"Notificando que {observable.Name} NÃO está recebendo atualizações de {Symbol}");
        }

        private void Notify()
        {
            foreach (var investor in _observables)
            {
                investor.Notify(this);
            }

            Console.WriteLine("");
        }
    }
}