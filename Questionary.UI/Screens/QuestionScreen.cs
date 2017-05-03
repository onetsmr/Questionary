using Questionary.Business.Commands.Infrastructure;
using Questionary.Domain.Enums;
using Questionary.UI.Screens.Infrastructure;

namespace Questionary.UI.Screens
{
    public class QuestionScreen : QuestionScreenBase
    {
        public QuestionScreen(IScreenRender screenRender, CommandModel model)
            : base(screenRender, model)
        {
        }

        public override ScreenTypeEnum ScreenType => ScreenTypeEnum.Question;
    }
}
