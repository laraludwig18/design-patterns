namespace DesignPatterns.Behavioral.Command
{
    internal abstract class Commander
    {
        public abstract void Execute();
        public abstract void Undo();
    }
}