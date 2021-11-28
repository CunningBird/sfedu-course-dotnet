using System;
using System.Collections.Generic;
using System.Linq;
using Library;
using NUnit.Framework;

namespace Test
{
    public class Task66Test {
        
        [SetUp]
        public void Setup() { }

        [Test]
        public void TestJoinSeq() {
            IEnumerable<int> seq1 = Task61.ArithmeticProgression(-1, 2, 6);
            IEnumerable<double> seq2 = Task61.ArithmeticProgression(1.5, 0.5, 6);
            List<Tuple<int, double>> joinedExpected = new List<Tuple<int, double>>() {
                new Tuple<int, double>(-1, 1.5), new Tuple<int, double>(1, 2),
                new Tuple<int, double>(3, 2.5), new Tuple<int, double>(5, 3),
                new Tuple<int, double>(7, 3.5), new Tuple<int, double>(9, 4)
            };
            IEnumerable<Tuple<int, double>> joined = Task66<int, double>.JoinSeq(seq1, seq2);
            Assert.AreEqual(joinedExpected.Count(), joined.Count());
            
            int index = 0;
            foreach (var j in joined) {
                Assert.AreEqual(joinedExpected[index], j);
                index++;
            }

            Assert.AreEqual(joined.Count(), index);

            IEnumerable<double> seq3 = Task61.ArithmeticProgression(-5, 2.6, 65);
            IEnumerable<double> seq4 = Task61.ArithmeticProgression(1.5, -25.5, 15);
            IEnumerable<Tuple<double, double>> joinedNew;
            try {
                joinedNew = Task66<double, double>.JoinSeq(seq3, seq4);
            } catch (ArgumentException) {
                Assert.AreNotEqual(seq3.Count(), seq4.Count());
            }
        }
    }
}