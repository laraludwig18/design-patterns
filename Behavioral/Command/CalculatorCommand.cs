using System;

namespace DesignPatterns.Behavioral.Command
{
    internal class CalculatorCommand : Commander
    {
        private char _operator;
        private int _value;
        private readonly Calculator _calculator;

        public CalculatorCommand(Calculator calculator, char operador, int valor)
        {
            _calculator = calculator;
            _operator = operador;
            _value = valor;
        }

        public char Operator
        {
            set => _operator = value;
        }

        public int Operand
        {
            set => _value = value;
        }

        public override void Execute()
        {
            _calculator.Operation(_operator, _value);
        }

        public override void Undo()
        {
            _calculator.Operation(Undo(_operator), _value);
        }

        private static char Undo(char operador)
        {
            switch (operador)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("Unknown operator");
            }
        }
    }
}