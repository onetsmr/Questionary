using System;
using Questionary.Business.Commands.Infrastructure;
using Questionary.Domain.Enums;

namespace Questionary.UI.Screens.Infrastructure
{
    public static class ScreenFactory
    {
        public static Screen CreateScreen(IScreenRender render, ScreenTypeEnum screenType, CommandModel model = null)
        {
            if (ScreenFactoryDictionary.All.ContainsKey(screenType) == false)
            {
                throw new ArgumentOutOfRangeException("screenType");
            }

            return (Screen)Activator.CreateInstance(ScreenFactoryDictionary.All[screenType], render, model);
        }
    }
}
