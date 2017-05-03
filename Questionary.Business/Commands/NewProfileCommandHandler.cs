using System.Linq;
using Questionary.Business.Commands.Infrastructure;
using Questionary.Business.Domain;
using Questionary.Domain.Enums;

namespace Questionary.Business.Commands
{
    public class NewProfileCommandHandler : CommandHandler
    {
        public override CommandExecutionResult Execute(string parameters, CommandModel model = null)
        {
            var questionForm = QuestionFormFactory.CreateDefaultQuestionForm();

            return new CommandExecutionResult(ScreenTypeEnum.QuestionFirst,
                new CommandModel(questionForm.Questions.First()));
        }
    }
}
