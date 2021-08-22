namespace DesignPatterns.Creational.AbstractFactory
{
    public class RescueSmallVehicleFactory : RescueVehicleFactory
    {
        public override Vehicle CreateVehicle(string model, Size size)
        {
            return VehicleCreator.Create(model, size);
        }

        public override Winch CreateWinch()
        {
            return WinchCreator.Create(Size.Small);
        }
    }
}