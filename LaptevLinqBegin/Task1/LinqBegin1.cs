using PT4;
using System.Linq;

namespace PT4Tasks
{
    public class MyTask : PT
    {
        public static void Solve()
        {
            Task("LinqBegin1");
        
            var input = GetEnumerableInt();

            var FirstPositive = input.Where(item => item > 0).First();
            var LastNegative = input.Where(item => item < 0).Last();

            Put(FirstPositive);
            Put(LastNegative);
        }
    }
}
