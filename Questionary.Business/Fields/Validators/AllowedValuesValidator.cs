using System.Linq;
using Questionary.Business.Fields.Validators.Infrastructure;
using Questionary.Resources;
using Questionary.Utils;

namespace Questionary.Business.Fields.Validators
{
    public class AllowedValuesValidator : FieldValidator
    {
        private readonly string[] _allowedValues;

        public AllowedValuesValidator(string[] allowedValues)
        {
            _allowedValues = allowedValues;
        }

        public override FieldValidatorResult Validate(string value)
        {
            return _allowedValues.Any(allowedValue => allowedValue.ToLower() == value.ToLower())
                ? FieldValidatorResult.Valid()
                : FieldValidatorResult.Invalid($"{Text.System.AllowedValuesValidator} {_allowedValues.Join()}");
        }
    }
}
