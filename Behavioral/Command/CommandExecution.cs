using System;

namespace DesignPatterns.Behavioral.Command
{
    public class CommandExecution
    {
        public static void Execute()
        {
            var user = new User();

            user.Add('+', 100);
            user.Add('-', 50);
            user.Add('*', 10);
            user.Add('/', 2);

            user.Undo(4);

            user.Return(3);
        }
    }
}