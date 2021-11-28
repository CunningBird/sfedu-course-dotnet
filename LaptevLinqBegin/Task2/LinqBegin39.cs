using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin39");

            GetEnumerableString().SelectMany(n => n.Where(c => char.IsDigit(c))).Put();
        }
    }
}
