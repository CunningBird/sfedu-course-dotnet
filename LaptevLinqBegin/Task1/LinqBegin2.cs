using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin2");

            var D = GetInt();
            var sequence = GetEnumerableInt();

            var result = sequence.Where(item => (item > 0 && item % 10 == D)).DefaultIfEmpty(0).First();

            Put(result);
        }
    }
}
