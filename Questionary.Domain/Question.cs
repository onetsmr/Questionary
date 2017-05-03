using System.Web.Script.Serialization;
using Questionary.Domain.Enums;
using Questionary.Domain.Interfaces;

namespace Questionary.Domain
{
    public class Question : IValidatableField
    {
        public int Id { get; set; }

        public int Number { get; set; }

        public string Description { get; set; }

        public DateTypeEnum DateType { get; set; }

        public bool IsRequired { get; set; }

        public string[] AllowedValues { get; set; }

        [ScriptIgnore] // Для предотвращения ошибки циклических ссылок при сериализации, см. QuestionFormExtensions.cs
        public QuestionForm QuestionForm { get; set; }

        public Answer Answer { get; set; }
    }
}
