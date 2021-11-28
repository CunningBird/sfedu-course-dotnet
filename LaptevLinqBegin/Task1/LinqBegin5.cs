using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin5");

            var C = GetChar();
            var A = GetEnumerableString();

            int result = A.Where(item => item.Length > 1 && item[0] == C && item[item.Length - 1] == C).Count();

            Put(result);
        }
    }
}
