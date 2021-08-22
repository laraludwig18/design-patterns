using System.Collections.Generic;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class AbstractFactoryExecution
    {
        public static void Execute()
        {
            var vehicles = new List<Vehicle>
            {
                VehicleCreator.Create("Celta", Size.Small),
                VehicleCreator.Create("Jetta", Size.Medium),
                VehicleCreator.Create("BMW X6", Size.Large)
            };

            vehicles.ForEach(v => RescueVehicle.CreateRescueVehicle(v).PerformanceService());
        }
    }
}