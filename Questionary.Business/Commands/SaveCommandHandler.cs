using Questionary.Business.Commands.Infrastructure;
using Questionary.Business.PrintForms;
using Questionary.Data;
using Questionary.Domain;
using Questionary.Utils;

namespace Questionary.Business.Commands
{
    public class SaveCommandHandler : CommandHandler
    {
        private DataBase<QuestionForm> _db;
        private FileStorage _fileStorage;

        public SaveCommandHandler()
        {
            _db = new DataBase<QuestionForm>();
            _fileStorage = new FileStorage(Configuration.DefaultProfilesFolder);
        }

        public override CommandExecutionResult Execute(string parameters, CommandModel model = null)
        {
            var question = model.Data.As<Question>();

            _db.Entities.Add(question.QuestionForm);
            _db.SaveChanges();

            var printForm = DefaultPrintForm.Print(question.QuestionForm);
            _fileStorage.SaveFile(printForm.FileName, printForm.Data);

            return new GoToMainScreenCommandHandler().Execute(null);
        }
    }
}
