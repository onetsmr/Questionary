using Questionary.Business.Validation.Infrastructure;
using Questionary.Resources;
using Questionary.Utils;

namespace Questionary.Business.Validation
{
    public class RequiredValidator : FieldValidator
    {
        public override FieldValidatorResult Validate(string value)
        {
            return value.Trim().IsNullOrEmpty() == false
                ? FieldValidatorResult.Valid()
                : FieldValidatorResult.Invalid(Text.System.RequiredValidatorError);
        }
    }
}
