using System.Web.Script.Serialization;

namespace Questionary.Utils
{
    public static class SerializeExtensions
    {
        public static string Serialize(this object obj)
        {
            return new JavaScriptSerializer().Serialize(obj);
        }

        public static T Deserialize<T>(this string data)
        {
            return new JavaScriptSerializer().Deserialize<T>(data);
        }
    }
}
