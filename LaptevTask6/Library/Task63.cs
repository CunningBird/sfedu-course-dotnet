using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Library
{
    public class Task63 {
        public static IEnumerable<int>  InfiniteRandomNumberSequence(int min = Int32.MinValue, int max = Int32.MaxValue) {
            Random rnd = new Random();
            while (true) { yield return rnd.Next(min, max); }
        }
        
        public static IEnumerable<double> InfiniteRandomNumberSequence(double min, double max) {
            Random rnd = new Random();
            double range = max - min;
            while (true) { yield return rnd.NextDouble() * range + min; }
        }
        
        public static IEnumerable<double> InfiniteRandomNumberSequence(double min) {
            Random rnd = new Random();
            double range = min;
            while (true) { yield return rnd.NextDouble() * range; }
        }
        
        public static string InfiniteRandomNumberSequenceToString(int n, int min = Int32.MinValue, int max = Int32.MaxValue) {
            if (min > max) { throw new ArgumentOutOfRangeException(); }
            IEnumerable<int> randomNumbers = InfiniteRandomNumberSequence(min, max).Take(n);
            string output = "\nRandom numbers: ";
            foreach (var rnd in randomNumbers) { output += $"{rnd}, "; }

            return output;
        }
        
        public static string InfiniteRandomNumberSequenceToString(int n, double min = Double.MinValue, double max = Double.MaxValue) {
            if (min > max) { throw new ArgumentOutOfRangeException(); }
            IEnumerable<double> randomNumbers = InfiniteRandomNumberSequence(min, max).Take(n);
            string output = "\nRandom numbers: ";
            foreach (var rnd in randomNumbers) { output += $"{rnd}, "; }

            return output;
        }
        
        public static void InfiniteRandomNumberSequencePrint(int n, int min = Int32.MinValue, int max = Int32.MaxValue) {
            Console.WriteLine(InfiniteRandomNumberSequenceToString(n, min, max));
        }
        
        public static void InfiniteRandomNumberSequencePrint(int n, double min = Double.MinValue, double max = Double.MaxValue) {
            Console.WriteLine(InfiniteRandomNumberSequenceToString(n, min, max));
        }
    }
}