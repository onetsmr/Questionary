using System;
using Questionary.Business.Commands.Infrastructure;
using Questionary.Domain.Enums;
using Questionary.Resources;
using Questionary.UI.Screens.Infrastructure;

namespace Questionary.UI
{
    public static class Dispatcher
    {
        private static IScreenRender _render;
        private static ExecutionContext _executionContext = new ExecutionContext();

        public static void Run(IScreenRender render)
        {
            _render = render;

            MainScreen();

            while (_executionContext.CurrentScreen != null)
            {
                RenderScreen();
                WaitForUserInput();
                PerformCommand();
            }
        }

        private static void MainScreen()
        {
            _executionContext.CurrentScreen = ScreenFactory.CreateScreen(_render,
                ScreenTypeEnum.Main, new CommandModel(Text.MainScreen.DefaultBody));
        }

        private static void RenderScreen()
        {
            _executionContext.CurrentScreen.Render();
        }

        private static void WaitForUserInput()
        {
            var userInput = _executionContext.CurrentScreen.WaitForUserInput();
            _executionContext.Command = Command.Parse(userInput, _executionContext.CurrentScreenIsQuestion);
        }

        private static void PerformCommand()
        {
            if (CommandIsNotAllowed())
            {
                return;
            }

            CommandExecutionResult result = null;

            try
            {
                result = CommandHandlerFactory
                    .Create(_executionContext.Command.CommandType)
                    .Execute(_executionContext.Command.Parameters,
                             _executionContext.CurrentScreen.Model);
            }
            catch (Exception exception)
            {
                ExceptionScreen(exception);
                return;
            }

            _executionContext.CurrentScreen = result.NextScreenType.HasValue
                ? ScreenFactory.CreateScreen(_render, result.NextScreenType.Value, result.Model)
                : null;

            _executionContext.Command = null;

            _render.Clear();
        }

        private static bool CommandIsNotAllowed()
        {
            if (_executionContext.CurrentScreen.IsCommandAllowed(_executionContext.Command.CommandType) == false)
            {
                _executionContext.CurrentScreen.RenderSystemMessage(Text.System.CommandIsNotAllowed);
                _executionContext.Command = null;
                return true;
            }

            return false;
        }

        private static void ExceptionScreen(Exception exception)
        {
            _executionContext.CurrentScreen = ScreenFactory.CreateScreen(_render,
                ScreenTypeEnum.Main, new CommandModel(null, exception.ToString()));
            _executionContext.Command = null;
            _render.Clear();
        }
    }
}
