namespace Questionary.Business.Fields.Validators.Infrastructure
{
    public abstract class FieldValidator
    {
        public abstract FieldValidatorResult Validate(string value);
    }
}
