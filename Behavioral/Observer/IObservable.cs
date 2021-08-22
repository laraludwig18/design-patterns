namespace DesignPatterns.Behavioral.Observer
{
    // Observer
    public interface IObservable
    {
        string Name { get; }
        void Notify(Investment investment);
    }
}