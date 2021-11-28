using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin27");

            int D = GetInt();
            var A = GetEnumerableInt();

            var result = A.SkipWhile(item => item <= D).Where(item => item >= 0 && item % 2 != 0).Reverse();

            result.Put();
        }
    }
}
