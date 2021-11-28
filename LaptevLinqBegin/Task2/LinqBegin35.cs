using PT4;
using System;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin35");

            var numsSeq = GetEnumerableInt();

            var res = numsSeq.Select((item, i) => item * (i + 1)).Where(item => (Math.Abs(item) >= 10 && Math.Abs(item) <= 99)).Reverse();

            res.Put();
        }
    }
}
