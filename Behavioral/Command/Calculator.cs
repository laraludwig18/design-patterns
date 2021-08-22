using System;

namespace DesignPatterns.Behavioral.Command
{
    internal class Calculator
    {
        private int _actualValue;

        public void Operation(char op, int value)
        {
            switch (op)
            {
                case '+': _actualValue += value; break;
                case '-': _actualValue -= value; break;
                case '*': _actualValue *= value; break;
                case '/': _actualValue /= value; break;
            }

            Console.WriteLine("(from {1} {2}) - actual value = {0,3}", _actualValue, op, value);
        }
    }
}