using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class SmallWinch : Winch
    {
        public SmallWinch(Size size) : base(size)
        {
        }

        public override void Rescue(Vehicle vehicle)
        {
            Console.WriteLine("Rescue small vehicle - Model " + vehicle.Model);
        }
    }
}