using System;
using System.Text;
using Questionary.Business.PrintForms.Infrastructure;
using Questionary.Domain;
using Questionary.Resources;

namespace Questionary.Business.PrintForms
{
    public static class DefaultPrintForm
    {
        public static PrintForm Print(QuestionForm questionForm)
        {
            var printForm = new PrintForm();

            var sb = new StringBuilder();

            foreach (var question in questionForm.Questions)
            {
                if (question.Number == 1)
                {
                    printForm.FileName = $"{question.Answer?.Value?.ToString() ?? Guid.NewGuid().ToString()}.txt";
                }

                sb.AppendLine($"{question.Number}. {question.Description}: {question.Answer?.Value?.ToString() ?? string.Empty}");
            }

            sb.AppendLine(string.Empty);
            sb.AppendLine($"{Text.System.ProfileCreateDate} {DateTime.Now.ToShortDateString()}");

            printForm.Data = sb.ToString();

            return printForm;
        }
    }
}
