using Questionary.Business.Commands.Infrastructure;
using Questionary.Domain.Enums;
using Questionary.Resources;

namespace Questionary.Business.Commands
{
    public class GoToMainScreenCommandHandler : CommandHandler
    {
        public override CommandExecutionResult Execute(string parameters, CommandModel model = null)
        {
            return new CommandExecutionResult(ScreenTypeEnum.Main,
                new CommandModel(Text.MainScreen.DefaultBody));
        }
    }
}
