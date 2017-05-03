using System.Collections.Generic;
using System.Linq;
using Questionary.Domain;

namespace Questionary.Business.Domain
{
    public static class QuestionFormFactory
    {
        private static Dictionary<string, QuestionForm> _questionForms;

        static QuestionFormFactory()
        {
            _questionForms = QuestionForms.All.ToDictionary(e => e.Name, e => e);
        }

        public static QuestionForm CreateDefaultQuestionForm()
        {
            return CreateQuestionForm("Default");
        }

        public static QuestionForm CreateQuestionForm(string name)
        {
            return _questionForms[name].DeepCopy();
        }
    }
}
