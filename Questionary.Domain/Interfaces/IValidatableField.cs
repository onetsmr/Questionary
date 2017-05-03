using Questionary.Domain.Enums;

namespace Questionary.Domain.Interfaces
{
    public interface IValidatableField
    {
        DateTypeEnum DateType { get; }

        bool IsRequired { get; }

        string[] AllowedValues { get; }
    }
}
