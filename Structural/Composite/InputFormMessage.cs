using System;

namespace DesignPatterns.Structural.Composite
{
    public class InputFormMessage : IMessage
    {
        public string Name { get; set; }

        public InputFormMessage(string name)
        {
            Name = name;
        }
        public void ShowMessages(int sub)
        {
            Console.WriteLine(new string('-', sub) + Name);
        }
    }
}