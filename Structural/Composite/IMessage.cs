namespace DesignPatterns.Structural.Composite
{
    public interface IMessage
    {
        string Name { get; set; }
        void ShowMessages(int sub);
    }
}