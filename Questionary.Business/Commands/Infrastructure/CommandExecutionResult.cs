using Questionary.Domain.Enums;

namespace Questionary.Business.Commands.Infrastructure
{
    public class CommandExecutionResult
    {
        public CommandExecutionResult(ScreenTypeEnum? nextScreenType, CommandModel model)
        {
            NextScreenType = nextScreenType;
            Model = model;
        }

        public ScreenTypeEnum? NextScreenType { get; }

        public CommandModel Model { get; }
    }
}
