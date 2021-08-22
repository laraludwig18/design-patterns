namespace DesignPatterns.Creational.AbstractFactory
{
    // Abstract factory
    public abstract class RescueVehicleFactory
    {
        public abstract Vehicle CreateVehicle(string model, Size size);
        public abstract Winch CreateWinch();
    }
}