using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin53");

            var A = GetEnumerableInt();
            var B = GetEnumerableInt();

            var res = A.SelectMany((itemA) => B.Select((itemB) => itemA + itemB)).Distinct().OrderBy(item => item);

            res.Put();
        }
    }
}
