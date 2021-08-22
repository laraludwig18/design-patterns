using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    // Client class
    public class RescueVehicle
    {
        private readonly Vehicle _vehicle;
        private readonly Winch _winch;

        public RescueVehicle(RescueVehicleFactory rescueVehicleFactory, Vehicle vehicle)
        {
            _vehicle = rescueVehicleFactory.CreateVehicle(vehicle.Model, vehicle.Size);
            _winch = rescueVehicleFactory.CreateWinch();
        }

        public void PerformanceService()
        {
            _winch.Rescue(_vehicle);
        }

        public static RescueVehicle CreateRescueVehicle(Vehicle vehicle) => vehicle.Size switch
        {
            Size.Small => new RescueVehicle(new RescueSmallVehicleFactory(), vehicle),
            Size.Medium => new RescueVehicle(new RescueMediumVehicleFactory(), vehicle),
            Size.Large => new RescueVehicle(new RescueLargeVehicleFactory(), vehicle),
            _ => throw new ApplicationException("Não foi possível identificar o veículo"),
        };
    }
}