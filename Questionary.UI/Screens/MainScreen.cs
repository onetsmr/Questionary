using Questionary.Business.Commands.Infrastructure;
using Questionary.Domain.Enums;
using Questionary.UI.Screens.Infrastructure;
using Questionary.Utils;

namespace Questionary.UI.Screens
{
    public class MainScreen : Screen
    {
        public MainScreen(IScreenRender screenRender, CommandModel model)
            : base(screenRender, model)
        {
        }

        public override ScreenTypeEnum ScreenType => ScreenTypeEnum.Main;

        protected override CommandTypeEnum[] GetAllowedCommands()
        {
            return new[]
            {
                CommandTypeEnum.new_profile,
                CommandTypeEnum.help,
                CommandTypeEnum.exit
            };
        }

        public override void Render()
        {
            ScreenRender.WriteLine(Model.Data.As<string>() ?? Model.SystemMessage ?? string.Empty);
        }
    }
}
