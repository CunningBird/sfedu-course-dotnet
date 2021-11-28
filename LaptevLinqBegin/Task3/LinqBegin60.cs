using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin60");

            GetEnumerableString().GroupBy(c => c[0], (c, s) => new { a = s.Select(e => e.Length).Sum(), c })
                .OrderByDescending(e => e.a)
                .ThenBy(e => e.c).Select(e => e.a.ToString() + '-' + e.c)
                .Put();
        }
    }
}
