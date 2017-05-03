using Questionary.Business.Commands.Infrastructure;
using Questionary.Domain.Enums;
using Questionary.UI.Screens.Infrastructure;

namespace Questionary.UI
{
    public class ExecutionContext
    {
        public Screen CurrentScreen { get; set; }

        public Command Command { get; set; }

        public bool CurrentScreenIsQuestion
        {
            get
            {
                return CurrentScreen != null && (
                    CurrentScreen.ScreenType == ScreenTypeEnum.QuestionFirst ||
                    CurrentScreen.ScreenType == ScreenTypeEnum.Question ||
                    CurrentScreen.ScreenType == ScreenTypeEnum.QuestionLast);
            }
        }
    }
}
