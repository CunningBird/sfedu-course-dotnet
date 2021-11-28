using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin6");

            var strSeq = GetEnumerableString();
            int lengthSum = strSeq.Aggregate(0, (acc, x) => acc + x.Length);

            Put(lengthSum);
        }
    }
}
