using Questionary.Business.Commands.Infrastructure;

namespace Questionary.Business.Commands
{
    public class ExitCommandHandler : CommandHandler
    {
        public override CommandExecutionResult Execute(string parameters, CommandModel model = null)
        {
            return new CommandExecutionResult(null, null);
        }
    }
}
