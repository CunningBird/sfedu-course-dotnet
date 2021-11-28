using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Task64a
    {
        public static IEnumerable<int> FibonacciNumberSequence() {
            int previousNum = 0;
            int currentNum = 1;

            yield return previousNum;
            yield return currentNum;

            while (true) {
                (previousNum, currentNum) = (currentNum, currentNum + previousNum);
                yield return currentNum;
            }
        }
        public static IEnumerable<int> FibonacciNumberSequence(int nth) {
            IEnumerable<int> fibNums = FibonacciNumberSequence().Take(nth);
            int previousNum = fibNums.Take(nth - 1).Last();
            int currentNum = fibNums.Take(nth).Last();

            while (true) {
                (previousNum, currentNum) = (currentNum, currentNum + previousNum);
                yield return currentNum;
            }
        }
        
        public static string FibonacciNumberSequenceToString(int n) {
            if (n < 1) { throw new ArgumentOutOfRangeException(); }
            IEnumerable<int> fibNums = FibonacciNumberSequence().Take(n);
            string output = "\nFibonacci Numbers: ";
            foreach (var num in fibNums) { output += $"{num}, "; }
            
            return output;
        }

        public static string FibonacciNumberSequenceToString(int n, int nth) {
            if (n < 1) { throw new ArgumentOutOfRangeException(); }
            IEnumerable<int> fibNums = FibonacciNumberSequence(nth).Take(n);
            string output = "\nFibonacci Numbers: ";
            foreach (var num in fibNums) { output += $"{num}, "; }

            return output;
        }

        public static void FibonacciNumberSequencePrint(int n) {
            Console.WriteLine(FibonacciNumberSequenceToString(n));
        }
        
        public static void FibonacciNumberSequencePrint(int n, int nth) {
            Console.WriteLine(FibonacciNumberSequenceToString(n, nth));
        }

    }
}