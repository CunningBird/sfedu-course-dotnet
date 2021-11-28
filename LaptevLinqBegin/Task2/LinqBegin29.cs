using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin29");

            int D = GetInt();
            int K = GetInt();
            var A = GetEnumerableInt();

            var result = A.TakeWhile(i => i <= D).Union(A.Skip(K - 1)).OrderByDescending(i => i);

            result.Put();
        }
    }
}
