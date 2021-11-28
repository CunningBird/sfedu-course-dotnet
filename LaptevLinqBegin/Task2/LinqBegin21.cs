using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin21");

            var input = GetEnumerableString();

            var result = input.OrderBy(s => s.Length).ThenByDescending(s => s);
            result.Put();
        }
    }
}
