using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin40");

            int k = GetInt();

            GetEnumerableString().Where(s => s.Length >= k).SelectMany(n => n.ToString()).Reverse().Put();
        }
    }
}
