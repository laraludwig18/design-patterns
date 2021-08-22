using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class LargeWinch : Winch
    {
        public LargeWinch(Size size) : base(size)
        {
        }

        public override void Rescue(Vehicle vehicle)
        {
            Console.WriteLine("Rescue large vehicle - Model " + vehicle.Model);
        }
    }
}