using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin36");

            GetEnumerableString().Select(s => s.Length % 2 == 1 ? s[0] : s[s.Length - 1]).OrderByDescending(s => s).Put();
        }
    }
}
