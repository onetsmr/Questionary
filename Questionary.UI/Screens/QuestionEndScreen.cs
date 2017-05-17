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
        }

        public override ScreenTypeEnum ScreenType => ScreenTypeEnum.QuestionLast;

        protected override CommandTypeEnum[] GetAllowedCommands()
        {
            return new[]
            {
                CommandTypeEnum.save
            };
        }

        public override void Render()
        {
            ScreenRender.WriteLine(Text.QuestionScreen.End);
        }
    }
}
