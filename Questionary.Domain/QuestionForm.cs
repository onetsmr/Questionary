using System.Collections.Generic;

namespace Questionary.Domain
{
    public class QuestionForm
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Question> Questions { get; set; }
    }
}
