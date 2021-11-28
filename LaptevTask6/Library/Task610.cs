using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Task610<T> {
        public static IEnumerable<(T, T)> SeqToPairs(IEnumerable<T> seq) {
            if (seq.Count() < 2) { throw new ArgumentException("Count of elements <2", "seq"); }

            T A = default;
            T B = default;
            int index = 0;

            foreach (var elem in seq) {
                if (index == 0) {
                    A = elem;
                } else if (index == 1) {
                    B = elem;
                    yield return (A, B);
                } else {
                    A = B;
                    B = elem;
                    yield return (A, B);
                }
                index++;
            }
        }
    }
}