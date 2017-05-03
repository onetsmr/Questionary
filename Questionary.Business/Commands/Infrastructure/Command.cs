using System;
using System.Linq;
using Questionary.Domain.Enums;
using Questionary.Utils;

namespace Questionary.Business.Commands.Infrastructure
{
    public class Command
    {
        public CommandTypeEnum CommandType { get; private set; }

        public string Parameters { get; private set; }

        public static Command Parse(object userInput, bool currentScreenIsQuestion)
        {
            if (userInput is string)
            {
                var stringUserInput = userInput.As<string>();

                if (stringUserInput.StartsWith("-"))
                {
                    foreach (CommandTypeEnum commandType in Enum.GetValues(typeof(CommandTypeEnum)).Cast<CommandTypeEnum>())
                    {
                        if (stringUserInput.StartsWith($"-{commandType.ToString()}"))
                        {
                            return new Command
                            {
                                CommandType = commandType,
                                Parameters = string.Join(" ", stringUserInput.Split(' ').Skip(1))
                            };
                        }
                    }
                }
                else if (currentScreenIsQuestion)
                {
                    return new Command
                    {
                        CommandType = CommandTypeEnum.Answer,
                        Parameters = stringUserInput
                    };
                }
            }

            if (userInput is ConsoleKeyInfo)
            {
                return new Command
                {
                    CommandType = CommandTypeEnum.GoToMainScreen
                };
            }

            return new Command
            {
                CommandType = CommandTypeEnum.Unknown
            };
        }
    }
}
