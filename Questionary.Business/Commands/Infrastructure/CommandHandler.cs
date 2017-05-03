namespace Questionary.Business.Commands.Infrastructure
{
    public abstract class CommandHandler
    {
        public abstract CommandExecutionResult Execute(string parameters, CommandModel model = null);
    }
}
