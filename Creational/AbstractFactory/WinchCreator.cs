using System;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class WinchCreator
    {
        public static Winch Create(Size size) => size switch
        {
            Size.Small => new SmallWinch(size),
            Size.Medium => new MediumWinch(size),
            Size.Large => new LargeWinch(size),
            _ => throw new ApplicationException("Unknown Winch size."),
        };
    }
}