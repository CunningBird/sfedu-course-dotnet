using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;

namespace Library
{
    public class Task66<T1, T2> {
        public static IEnumerable<Tuple<T1, T2>> JoinSeq(IEnumerable<T1> seq1, IEnumerable<T2> seq2) {
            if (seq1.Count() != seq2.Count()) { throw new ArgumentException("Sequences have different length!"); }

            IEnumerable<Tuple<T1, T2>> join = seq1.Zip(seq2, (s1, s2) => new Tuple<T1, T2>(s1, s2));
            return join;
        }
    }
}