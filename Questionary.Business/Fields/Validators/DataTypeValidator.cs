using Questionary.Business.Fields.Validators.Infrastructure;
using Questionary.Domain.Enums;
using Questionary.Resources;
using Questionary.Utils;

namespace Questionary.Business.Fields.Validators
{
    public class DataTypeValidator : FieldValidator
    {
        private DateTypeEnum _dateType;

        public DataTypeValidator(DateTypeEnum dateType)
        {
            _dateType = dateType;
        }

        public override FieldValidatorResult Validate(string value)
        {
            if (DataTypeDictionary.All.ContainsKey(_dateType) == false)
            {
                return FieldValidatorResult.Valid(value);
            }

            object parsedValue = null;

            return value.TryParse(DataTypeDictionary.All[_dateType], out parsedValue)
                ? FieldValidatorResult.Valid(parsedValue)
                : FieldValidatorResult.Invalid(Text.System.DataTypeValidator);
        }
    }
}
