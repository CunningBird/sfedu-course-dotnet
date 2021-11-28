using System.Collections.Generic;
using System.Linq;
using Library;
using NUnit.Framework;

namespace Test
{
    public class Task610Test {
        [SetUp]
        public void Setup() { }

        [Test]
        public void TestSeqToPairs() {
            IEnumerable<double> seq1 = Task61.ArithmeticProgression(3, 3.5, 10);
            IEnumerable<(double, double)> seqToPairs = Task610<double>.SeqToPairs(seq1);
            List<(double, double)> expected = new List<(double, double)>() {
                (3, 6.5), (6.5, 10), (10, 13.5), (13.5, 17), (17, 20.5),
                (20.5, 24), (24, 27.5), (27.5, 31), (31, 34.5)
            };
            Assert.AreEqual(expected.Count(), seqToPairs.Count());

            int index = 0;
            foreach (var pair in seqToPairs) {
                Assert.AreEqual(expected[index], pair);
                index++;
            }
        }
    }
}