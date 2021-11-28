using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin24");

            var K = GetInt();
            var sequence = GetEnumerableString();

            var result = sequence.Take(K - 1).Where(s => (s.Length % 2 > 0 && s[0] >= 'A' && s[0] <= 'Z')).Reverse();

            result.Put();
        }
    }
}
