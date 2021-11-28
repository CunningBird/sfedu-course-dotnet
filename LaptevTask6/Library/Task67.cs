using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Task67 {
        public static IEnumerable<int> FilteredSeq(IEnumerable<int> seq, Func<int, bool> condition) {
            return seq.Where(condition);
        }

        public static Func<int, bool> IsEven = number => number % 2 == 0;
    }
}