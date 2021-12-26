using PT4;
using System.Linq;
using System.Text;
using System.IO;

namespace PT4Tasks{
    public class MyTask : PT {
        public static void Solve() {
            Task("LinqObj10");

            var d = File.ReadAllLines(GetString(), Encoding.Default)
                .GroupBy(x => new { year = x.Split(' ')[0], month = x.Split(' ')[1] }, y => y, (x, y) => x.year + ' ' + x.month + ' ' + y.Count().ToString())
                .OrderByDescending(x => int.Parse(x.Split(' ')[0]))
                .ThenBy(x => int.Parse(x.Split(' ')[1]));

            File.WriteAllLines(GetString(), d, Encoding.Default);
        }
    }
}
