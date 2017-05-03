using Questionary.Business.Commands.Infrastructure;
using Questionary.Domain.Enums;
using Questionary.Resources;
using Questionary.UI.Screens.Infrastructure;

namespace Questionary.UI.Screens
{
    public class QuestionEndScreen : Screen
    {
        public QuestionEndScreen(IScreenRender screenRender, CommandModel model)
            : base(screenRender, model)
        {
            AllowedCommands.Add(CommandTypeEnum.save, CommandTypeEnum.save);
        }

        public override ScreenTypeEnum ScreenType => ScreenTypeEnum.QuestionLast;

        public override void Render()
        {
            ScreenRender.WriteLine(Text.QuestionScreen.End);
        }
    }
}
