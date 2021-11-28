using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin25");

            var K1 = GetInt();
            var K2 = GetInt();

            var sequence = GetEnumerableInt();

            var sum = sequence.Skip(K1 - 1).Take(K2 - K1 + 1).Where(item => item > 0).Sum();

            Put(sum);
        }
    }
}
