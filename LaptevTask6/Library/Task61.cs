using System;
using System.Collections.Generic;

namespace Library
{
    public class Task61 {
        public static IEnumerable<double> ArithmeticProgression(double a0, double d, int n) {
            if (n <= 0) { throw new ArgumentException("Should be >0", "n"); }

            double a = a0;
            yield return a;
            for (int i = 0; i < n - 1; ++i) {
                a += d;
                yield return a;
            }
        }

        public static IEnumerable<int> ArithmeticProgression(int a0, int d, int n) {
            if (n <= 0) { throw new ArgumentException("Should be >0", "n"); }

            int a = a0;
            yield return a;
            for (int i = 0; i < n - 1; ++i) {
                a += d;
                yield return a;
            }
        }

        public static string AriphmeticProgressionToString(double a0, double d, int n) {
            string output = "Ariphmetic progression :";

            IEnumerable<double> progression = ArithmeticProgression(a0, d, n);
            foreach (var number in progression) {
                output += $" {number} ;";
            }

            return output;
        }

        public static void AriphmeticProgressionPrint(double a0, double d, int n) {
            Console.WriteLine(AriphmeticProgressionToString(a0, d, n));
        }
    }
}