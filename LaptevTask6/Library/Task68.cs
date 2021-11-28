using System;
using System.Collections.Generic;

namespace Library
{
    public class Task68<T> {
        public static IEnumerable<T> ChangeSeq(IEnumerable<T> seq, Func<T, T> change) {
            foreach (var item in seq) { yield return change(item); }
        }

        public static Func<int, int> Sqr = n => n * n;
    }
}