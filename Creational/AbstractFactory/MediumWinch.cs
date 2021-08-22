using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class MediumWinch : Winch
    {
        public MediumWinch(Size size) : base(size)
        {
        }

        public override void Rescue(Vehicle vehicle)
        {
            Console.WriteLine("Rescue medium vehicle - Model " + vehicle.Model);
        }
    }
}