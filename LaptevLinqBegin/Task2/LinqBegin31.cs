using PT4;
using System;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin31");

            int K = GetInt();
            var A = GetEnumerableString();

            var seq1 = A.Take(K);
            var seq2 = A.Reverse().TakeWhile((item) => item != (A.Last(el => Char.IsDigit(el.Last()))));

            var res = seq1.Intersect(seq2).OrderBy((str) => str.Length).ThenBy(r => r);

            res.Put();
        }
    }
}
