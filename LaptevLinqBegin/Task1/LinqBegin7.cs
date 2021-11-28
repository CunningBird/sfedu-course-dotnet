using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin7");

            var i = GetEnumerableInt();

            Put(i.Count(e => e < 0));
            Put(i.Where(e => e < 0).Sum());
        }
    }
}
