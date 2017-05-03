using System;
using System.Collections.Generic;
using Questionary.Domain.Enums;

namespace Questionary.UI.Screens.Infrastructure
{
    public static class ScreenFactoryDictionary
    {
        public static readonly Dictionary<ScreenTypeEnum, Type> All = new Dictionary<ScreenTypeEnum, Type>
        {
            { ScreenTypeEnum.Main, typeof(MainScreen) },
            { ScreenTypeEnum.QuestionFirst, typeof(QuestionFirstScreen) },
            { ScreenTypeEnum.Question, typeof(QuestionScreen) },
            { ScreenTypeEnum.QuestionLast, typeof(QuestionLastScreen) },
            { ScreenTypeEnum.QuestionEnd, typeof(QuestionEndScreen) }
        };
    }
}
