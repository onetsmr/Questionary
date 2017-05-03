using System;

namespace Questionary.UI.Screens.Infrastructure
{
    public interface IScreenRender
    {
        void Clear();

        ConsoleKeyInfo ReadKey();

        string ReadLine();

        void WriteLine(string value);

        void WriteLine(string format, params object[] arg);
    }
}
