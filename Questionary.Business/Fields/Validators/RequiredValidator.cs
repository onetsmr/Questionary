using Questionary.Business.Fields.Validators.Infrastructure;
using Questionary.Resources;
using Questionary.Utils;

namespace Questionary.Business.Fields.Validators
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
