using System;
using System.Collections.Generic;
using Questionary.Domain.Enums;

namespace Questionary.Business.Validation.Infrastructure
{
    public static class DataTypeDictionary
    {
        public static readonly Dictionary<DateTypeEnum, Type> All = new Dictionary<DateTypeEnum, Type>
        {
            { DateTypeEnum.DateTime, typeof(DateTime) },
            { DateTypeEnum.Number, typeof(Int32) }
        };
    }
}
