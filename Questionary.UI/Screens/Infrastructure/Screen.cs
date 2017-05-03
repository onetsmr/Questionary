using System.Collections.Generic;
using Questionary.Business.Commands.Infrastructure;
using Questionary.Domain.Enums;
using Questionary.Utils;

namespace Questionary.UI.Screens.Infrastructure
{
    public abstract class Screen
    {
        protected readonly IScreenRender ScreenRender;

        protected readonly Dictionary<CommandTypeEnum, CommandTypeEnum> AllowedCommands;

        protected Screen(IScreenRender screenRender, CommandModel model)
        {
            ScreenRender = screenRender;
            AllowedCommands = new Dictionary<CommandTypeEnum, CommandTypeEnum>();
            Model = model;
        }

        public CommandModel Model { get; private set; }

        public bool IsCommandAllowed(CommandTypeEnum commandType)
        {
            return AllowedCommands.ContainsKey(commandType);
        }

        public void RenderSystemMessage(string systemMessage)
        {
            if (systemMessage.IsNullOrEmpty() == false)
            {
                ScreenRender.WriteLine(systemMessage);
            }
        }

        public virtual object WaitForUserInput()
        {
            return ScreenRender.ReadLine();
        }

        public abstract ScreenTypeEnum ScreenType { get; }

        public abstract void Render();
    }
}
