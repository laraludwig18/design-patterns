using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class VehicleCreator
    {
        public static Vehicle Create(string model, Size size) => size switch
        {
            Size.Small => new SmallVehicle(model, size),
            Size.Medium => new MediumVehicle(model, size),
            Size.Large => new LargeVehicle(model, size),
            _ => throw new ApplicationException("Unknown vehicle size."),
        };
    }
}