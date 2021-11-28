using PT4;
using System;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin52");

            var A = GetEnumerableString();
            var B = GetEnumerableString();

            var res = A.Where((item) => Char.IsDigit(item.Last()))
                .SelectMany((itemA) => B.Where((itemB) => Char.IsDigit(itemB.Last())).Select((itemB) => $"{itemA}={itemB}"))
                .OrderBy(elem => elem.Split('=')[0])
                .ThenByDescending(elem => elem.Split('=')[1]);

            res.Put();
        }
    }
}
