using System;
using System.Web.Script.Serialization;

namespace Questionary.Domain
{
    public class Answer
    {
        public int Id { get; set; }

        public Type ValueType { get; set; }

        public object Value { get; set; }

        [ScriptIgnore] // Для предотвращения ошибки циклических ссылок при сериализации, см. QuestionFormExtensions.cs
        public Question Question { get; set; }
    }
}
