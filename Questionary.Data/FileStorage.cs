using System.IO;
using Questionary.Utils;

namespace Questionary.Data
{
    public class FileStorage
    {
        private readonly string _folder;

        public FileStorage(string folder)
        {
            _folder = folder.GetSafeFileName();

            if (Directory.Exists(_folder) == false)
            {
                Directory.CreateDirectory(_folder);
            }
        }

        public void SaveFile(string fileName, string data)
        {
            var path = Path.Combine(_folder, fileName.GetSafeFileName());
            File.WriteAllText(path, data);
        }
    }
}
