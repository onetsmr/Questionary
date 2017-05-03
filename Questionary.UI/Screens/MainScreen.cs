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
            AllowedCommands.Add(CommandTypeEnum.new_profile, CommandTypeEnum.new_profile);
            AllowedCommands.Add(CommandTypeEnum.help, CommandTypeEnum.help);
            AllowedCommands.Add(CommandTypeEnum.exit, CommandTypeEnum.exit);
        }

        public override ScreenTypeEnum ScreenType => ScreenTypeEnum.Main;

        public override void Render()
        {
            ScreenRender.WriteLine(Model.Data.As<string>() ?? Model.SystemMessage ?? string.Empty);
        }
    }
}
