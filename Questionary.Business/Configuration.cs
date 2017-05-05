using System.Collections.Specialized;
using System.Configuration;

namespace Questionary.Business
{
    public static class Configuration
    {
        private static NameValueCollection _appSettings;

        static Configuration()
        {
            _appSettings = ConfigurationManager.AppSettings;
        }

        public static string DefaultProfilesFolder
        {
            get { return _appSettings["DefaultProfilesFolder"]; }
        }
    }
}
