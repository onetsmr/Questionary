namespace Questionary.Business.Validation.Infrastructure
{
    public abstract class FieldValidator
    {
        public abstract FieldValidatorResult Validate(string value);
    }
}
