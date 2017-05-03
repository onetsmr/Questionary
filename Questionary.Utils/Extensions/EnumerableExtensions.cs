using System.Collections.Generic;
using System.Linq;

namespace Questionary.Utils
{
    public static class EnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> @this)
        {
            return @this == null || !@this.Any();
        }
    }
}
