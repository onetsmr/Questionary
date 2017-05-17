using System.Collections.Generic;
using System.Linq;
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
            AllowedCommands = GetAllowedCommands().ToDictionary(e => e, e => e);
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

        protected abstract CommandTypeEnum[] GetAllowedCommands();

        public abstract void Render();
    }
}
