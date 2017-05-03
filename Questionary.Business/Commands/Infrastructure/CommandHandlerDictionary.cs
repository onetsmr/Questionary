using System;
using System.Collections.Generic;
using Questionary.Domain.Enums;

namespace Questionary.Business.Commands.Infrastructure
{
    public static class CommandHandlerDictionary
    {
        public static readonly Dictionary<CommandTypeEnum, Type> All = new Dictionary<CommandTypeEnum, Type>
        {
            { CommandTypeEnum.GoToMainScreen, typeof(GoToMainScreenCommandHandler) },
            { CommandTypeEnum.Answer, typeof(AnswerCommandHandler) },
            { CommandTypeEnum.new_profile, typeof(NewProfileCommandHandler) },
            { CommandTypeEnum.help, typeof(HelpCommandHandler) },
            { CommandTypeEnum.exit, typeof(ExitCommandHandler) }
        };
    }
}
