using System.IO;
using System.Text.RegularExpressions;

namespace Questionary.Utils
{
    public static class FileSystemExtensions
    {
        public static string GetSafeFileName(this string fileName)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(fileName, "");
        }
    }
}
