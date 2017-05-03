using System.Collections.Generic;
using Questionary.Domain;
using Questionary.Domain.Enums;

namespace Questionary.Business.Domain
{
    // TODO: загружать из файла с удобной структурой + поддержка локализаций

    /// <summary>
    /// Вопросы в каждой QuestionForm должны иметь уникальный Number и 
    /// быть отсортированы по Number по возрастанию.
    /// </summary>
    public static class QuestionForms
    {
        public static readonly QuestionForm[] All = new[]
        {
            Default()
        };

        public static QuestionForm Default()
        {
            var questionForm = new QuestionForm
            {
                Id = 1,
                Name = "Default",
                Questions = new List<Question>
                {
                    new Question
                    {
                        Id = 1,
                        Number = 1,
                        Description = "ФИО",
                        DateType = DateTypeEnum.String,
                        IsRequired = true,
                        Answer = new Answer
                        {
                            Id = 1
                        }
                    },
                    new Question
                    {
                        Id = 2,
                        Number = 2,
                        Description = "Дата рождения (Формат ДД.ММ.ГГГГ)",
                        DateType = DateTypeEnum.DateTime,
                        IsRequired = true,
                        Answer = new Answer
                        {
                            Id = 2
                        }
                    },
                    new Question
                    {
                        Id = 3,
                        Number = 3,
                        Description = "Любимый язык программирования (PHP, JavaScript, C, C++, Java, C#, Python, Ruby)",
                        DateType = DateTypeEnum.Choice,
                        IsRequired = true,
                        AllowedValues = new[] { "PHP", "JavaScript", "C", "C++", "Java", "C#", "Python", "Ruby" },
                        Answer = new Answer
                        {
                            Id = 3
                        }
                    },
                    new Question
                    {
                        Id = 4,
                        Number = 4,
                        Description = "Опыт программирования на указанном языке (Полных лет)",
                        DateType = DateTypeEnum.Number,
                        IsRequired = true,
                        Answer = new Answer
                        {
                            Id = 4
                        }
                    },
                    new Question
                    {
                        Id = 5,
                        Number = 5,
                        Description = "Мобильный телефон",
                        DateType = DateTypeEnum.String,
                        IsRequired = true,
                        Answer = new Answer
                        {
                            Id = 5
                        }
                    }
                }
            };

            return questionForm;
        }
    }
}
