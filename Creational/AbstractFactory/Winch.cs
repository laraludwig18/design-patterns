namespace DesignPatterns.Creational.AbstractFactory
{
    public abstract class Winch
    {
        public abstract void Rescue(Vehicle vehicle);
        public Size Size { get; set; }

        protected Winch(Size size)
        {
            Size = size;
        }
    }
}