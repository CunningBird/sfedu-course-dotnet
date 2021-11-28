using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Task62<T> {
        public static IEnumerable<T> InfiniteSeq(T val) {
            while (true) { yield return val; }
        }

        public static IEnumerable<T> TakeN<T>(IEnumerable<T> seq, int n) {
            if (n <= 0) { throw new ArgumentException("Should be >0", "n"); }
            return seq.Take(n);
        }
    }
}