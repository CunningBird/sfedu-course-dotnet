using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin50");

            var A = GetEnumerableString();
            var B = GetEnumerableString();

            var result = A.GroupJoin(B, a => a, b => b, (a, b) => $"{a}:{B.Where(s => s[0] == a[0]).Count()}").OrderBy(s => A.ToList().IndexOf(s.Split(':')[0]));

            result.Put();
        }
    }
}
