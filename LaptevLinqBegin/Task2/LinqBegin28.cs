using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin28");

            int L = GetInt();
            var A = GetEnumerableString();

            var result = A.TakeWhile(s => s.Length <= L).Where(s => s[s.Length - 1] >= 'A' && s[s.Length - 1] <= 'Z').OrderByDescending(s => s.Length).ThenBy(s => s);

            result.Put();
        }
    }
}
