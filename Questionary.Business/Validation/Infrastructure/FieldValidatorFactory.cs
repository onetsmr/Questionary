using System.Collections.Generic;
using Questionary.Domain.Interfaces;
using Questionary.Utils;

namespace Questionary.Business.Validation.Infrastructure
{
    public static class FieldValidatorFactory
    {
        public static IEnumerable<FieldValidator> CreateFieldValidators(IValidatableField validatableField)
        {
            var validators = new List<FieldValidator>();

            if (validatableField.IsRequired)
                validators.Add(new RequiredValidator());

            if (validatableField.AllowedValues.IsNullOrEmpty() == false)
                validators.Add(new AllowedValuesValidator(validatableField.AllowedValues));

            validators.Add(new DataTypeValidator(validatableField.DateType));

            return validators;
        }
    }
}
