using Questionary.Domain;

using Questionary.Utils;

namespace Questionary.Business.Domain
{
    public static class QuestionFormExtensions
    {
        public static QuestionForm DeepCopy(this QuestionForm original)
        {
            var questionForm = original.Serialize().Deserialize<QuestionForm>();

            foreach (var question in questionForm.Questions)
            {
                question.QuestionForm = questionForm;
                question.Answer.Question = question;
            }

            return questionForm;
        }
    }
}
