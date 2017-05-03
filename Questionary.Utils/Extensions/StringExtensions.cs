using System;
using System.ComponentModel;

namespace Questionary.Utils
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static string Join(this string[] values, string separator = ", ")
        {
            return string.Join(separator, values);
        }

        public static bool TryParse(this string value, Type type, out object parsedValue)
        {
            var converter = TypeDescriptor.GetConverter(type);

            if (converter != null && converter.IsValid(value))
            {
                parsedValue = converter.ConvertFromString(value);
                return true;
            }
            else
            {
                parsedValue = null;
                return false;
            }
        }
    }
}
