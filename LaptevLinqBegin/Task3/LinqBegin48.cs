using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin48");

            var A = GetEnumerableString();
            var B = GetEnumerableString();

            var result = A.Join(B, a => a.Length, b => b.Length, (a, b) => $"{a}:{b}").OrderBy(s => s.Split(':')[0]).ThenByDescending(s => s.Split(':')[1]);

            result.Put();
        }
    }
}
