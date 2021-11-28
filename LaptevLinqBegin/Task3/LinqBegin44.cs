using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin44");

            var K1 = GetInt();
            var K2 = GetInt();

            var A = GetEnumerableInt();
            var B = GetEnumerableInt();

            var result = A.Where(item => item > K1).Concat(B.Where(item => item < K2)).OrderBy(item => item);
            result.Put();
        }
    }
}
