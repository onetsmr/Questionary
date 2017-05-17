using System.Collections.Generic;
using System.IO;
using Questionary.Utils;

namespace Questionary.Data
{
    public class DataBase<T>
    {
        private const string FileName = "db.json";

        public List<T> Entities { get; private set; }

        public DataBase()
        {
            try
            {
                Entities = File.ReadAllText(FileName).Deserialize<List<T>>();
            }
            catch
            {
                Entities = new List<T>();
            }
        }

        public void SaveChanges()
        {
            File.WriteAllText(FileName, Entities.Serialize());
        }
    }
}
