using System;
using Questionary.UI.Screens.Infrastructure;

namespace Questionary.UI.Console
{
    public class ScreenRender : IScreenRender
    {
        public void Clear()
        {
            System.Console.Clear();
        }

        public ConsoleKeyInfo ReadKey()
        {
            return System.Console.ReadKey();
        }

        public string ReadLine()
        {
            return System.Console.ReadLine();
        }

        public void WriteLine(string value)
        {
            System.Console.WriteLine(value);
        }

        public void WriteLine(string format, params object[] arg)
        {
            System.Console.WriteLine(format, arg);
        }
    }
}
