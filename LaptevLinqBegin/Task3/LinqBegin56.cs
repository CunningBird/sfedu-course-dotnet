using PT4;
using System;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin56");

            GetEnumerableInt().GroupBy(d => Math.Abs(d % 10), s => s, (d, s) => string.Format("{0}:{1}", d, s.Sum()))
                .OrderBy(e => e)
                .Put();
        }
    }
}
