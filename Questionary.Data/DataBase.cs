using System.Collections.Generic;
using System.IO;
using Questionary.Utils;

namespace Questionary.Data
{
    public class DataBase<T>
    {
        private const string FileName = "db.json";

        public List<T> QuestionForms { get; private set; }

        public DataBase()
        {
            try
            {
                QuestionForms = File.ReadAllText(FileName).Deserialize<List<T>>();
            }
            catch
            {
                QuestionForms = new List<T>();
            }
        }

        public void SaveChanges()
        {
            File.WriteAllText(FileName, QuestionForms.Serialize());
        }
    }
}
