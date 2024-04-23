using System;
using System.Collections.Generic;
using System.Linq;

namespace ComicStripToKindle.Extensions
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<IGrouping<double, T>> GroupByWithTolerance<T>(this IEnumerable<T> source,
            Func<T, double> keySelector,
            double tolerance)
        {
            var orderedSource = source
                .Select(e => new { Key = keySelector(e), Value = e })
                .OrderBy(e => e.Key);

            if (!orderedSource.Any())
                yield break;

            var prev = orderedSource.First();
            var itemGroup = new Group<double, T>(prev.Key) { prev.Value };

            foreach (var current in orderedSource.Skip(1))
            {
                if (current.Key - prev.Key <= tolerance)
                {
                    itemGroup.Add(current.Value);
                }
                else
                {
                    yield return itemGroup;
                    itemGroup = new Group<double, T>(current.Key) { current.Value };
                }
                prev = current;
            }
            yield return itemGroup;
        }


        private class Group<TKey, TSource> : List<TSource>, IGrouping<TKey, TSource>
        {
            public Group(TKey key)
            {
                Key = key;
            }

            public TKey Key { get; }
        }

        public static IEnumerable<IGrouping<TKey, TSource>> GroupAdjacent<TSource, TKey>(
            this IEnumerable<TSource> source,
            Func<TSource, TKey> keySelector)
        {
            TKey last = default(TKey);
            bool haveLast = false;
            List<TSource> list = new List<TSource>();
            foreach (TSource s in source)
            {
                TKey k = keySelector(s);
                if (haveLast)
                {
                    if (!k.Equals(last))
                    {
                        yield return new GroupOfAdjacent<TSource, TKey>(list, last);
                        list = new List<TSource>();
                        list.Add(s);
                        last = k;
                    }
                    else
                    {
                        list.Add(s);
                        last = k;
                    }
                }
                else
                {
                    list.Add(s);
                    last = k;
                    haveLast = true;
                }
            }
            if (haveLast)
                yield return new GroupOfAdjacent<TSource, TKey>(list, last);
        }
    }
}
