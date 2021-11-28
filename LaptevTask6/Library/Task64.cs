using System;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Task64 {
        public static IEnumerable<double> InfiniteArithmeticProgression(double a0, double d) {
            double a = a0;
            yield return a;
            while (true) {
                a += d;
                yield return a;
            }
        }

        public static string InfiniteAriphmeticProgressionToString(double a0, double d, int n) {
            if (n <= 0) { throw new ArgumentException("Should be >0", "n"); }

            string output = "Ariphmetic progression :";

            IEnumerable<double> progression = InfiniteArithmeticProgression(a0, d).Take(n);
            foreach (var number in progression) { output += $" {number} ;"; }

            return output;
        }

        public static void InfiniteAriphmeticProgressionPrint(double a0, double d, int n) {
            Console.WriteLine(InfiniteAriphmeticProgressionToString(a0, d, n));
        }
    }
}