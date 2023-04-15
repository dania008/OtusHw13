using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHw13
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<T> Top<T>(this IEnumerable<T> source, int percentage)
        {
            if (percentage < 1 || percentage > 100)
            {
                throw new ArgumentException("Процент должен быть в диапазоне от 1 до 100.");
            }

            int count = source.Count();
            int topCount = (int)Math.Ceiling(count * percentage / 100.0);
            if (topCount == 0)
            {
                return Enumerable.Empty<T>();
            }

            return source.OrderByDescending(x => x).Take(topCount);
        }

        public static IEnumerable<T> Top<T, TKey>(this IEnumerable<T> source, int percentage, Func<T, TKey> keySelector)
        {
            if (percentage < 1 || percentage > 100)
            {
                throw new ArgumentException("Процент должен быть в диапазоне от 1 до 100.");
            }

            int count = source.Count();
            int topCount = (int)Math.Ceiling(count * percentage / 100.0);
            if (topCount == 0)
            {
                return Enumerable.Empty<T>();
            }

            return source.OrderByDescending(keySelector).Take(topCount);
        }
    }
}
