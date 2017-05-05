using Questionary.Business.Commands.Infrastructure;
using Questionary.Business.Validation.Infrastructure;
using Questionary.Domain;
using Questionary.Domain.Enums;
using Questionary.Utils;

namespace Questionary.Business.Commands
{
    public class AnswerCommandHandler : CommandHandler
    {
        public override CommandExecutionResult Execute(string answerValue, CommandModel model = null)
        {
            var question = model.Data.As<Question>();

            var validators = FieldValidatorFactory.CreateFieldValidators(question);

            foreach (var validator in validators)
            {
                var result = validator.Validate(answerValue);

                if (result.IsValid == false)
                {
                    return CurrentScreen(question, result);
                }
            }

            question.Answer.Value = answerValue;

            return NextScreen(question);
        }

        private CommandExecutionResult CurrentScreen(Question question, FieldValidatorResult result)
        {
            return new CommandExecutionResult(GetQuestionScreenType(question),
                new CommandModel(question, result.Message));
        }

        private CommandExecutionResult NextScreen(Question question)
        {
            var questions = question.QuestionForm.Questions;

            var screenType = GetQuestionScreenType(question, true);

            var commandModel = screenType == ScreenTypeEnum.QuestionEnd
                ? new CommandModel(question)
                : new CommandModel(questions[question.Number]);

            return new CommandExecutionResult(screenType, commandModel);
        }

        private ScreenTypeEnum GetQuestionScreenType(Question question, bool checkQuestionEnd = false)
        {
            var questions = question.QuestionForm.Questions;

            if (question.Number == 1)
            {
                return ScreenTypeEnum.QuestionFirst;
            }

            if (question.Number + 1 == questions.Count)
            {
                return ScreenTypeEnum.QuestionLast;
            }

            if (checkQuestionEnd)
            {
                if (question.Number == questions.Count)
                {
                    return ScreenTypeEnum.QuestionEnd;
                }
            }

            return ScreenTypeEnum.Question;
        }
    }
}
