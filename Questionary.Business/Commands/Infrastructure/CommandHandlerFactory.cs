using System;
using Questionary.Domain.Enums;

namespace Questionary.Business.Commands.Infrastructure
{
    public static class CommandHandlerFactory
    {
        public static CommandHandler Create(CommandTypeEnum commandType)
        {
            if (CommandHandlerDictionary.All.ContainsKey(commandType) == false)
            {
                throw new ArgumentOutOfRangeException("commandType");
            }

            return (CommandHandler)Activator.CreateInstance(CommandHandlerDictionary.All[commandType]);
        }
    }
}
