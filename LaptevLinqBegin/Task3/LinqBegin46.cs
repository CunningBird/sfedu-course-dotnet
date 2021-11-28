using PT4;
using System;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin46");

            var A = GetEnumerableInt();
            var B = GetEnumerableInt();

            var res = A.Join(B, a => a % 10, b => b % 10, (a, b) => $"{a}-{b}")
                .OrderBy(item => A.ToList().FindIndex(i => i == Int32.Parse(item.Split('-')[0])))
                .ThenBy(item => B.ToList().FindIndex(i => i == Int32.Parse(item.Split('-')[1])));

            res.Put();
        }
    }
}
