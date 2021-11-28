using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin34");

            var numsSeq = GetEnumerableInt();

            var res = numsSeq.Where(item => item % 2 != 0).Select(item => item.ToString()).OrderBy(item => item);

            res.Put();
        }
    }
}
