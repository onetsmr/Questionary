namespace Questionary.Business.Validation.Infrastructure
{
    public class FieldValidatorResult
    {
        public bool IsValid { get; private set; }

        public string Message { get; private set; }

        public object ParsedValue { get; private set; }

        public static FieldValidatorResult Valid(object parsedValue = null)
        {
            return new FieldValidatorResult
            {
                IsValid = true,
                Message = string.Empty,
                ParsedValue = parsedValue
            };
        }

        public static FieldValidatorResult Invalid(string message, object parsedValue = null)
        {
            return new FieldValidatorResult
            {
                IsValid = false,
                Message = message,
                ParsedValue = parsedValue
            };
        }
    }
}
