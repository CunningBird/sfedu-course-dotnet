using System.Collections.Generic;
using System.Linq;
using Library;
using NUnit.Framework;

namespace Test
{
    public class Task68Test {
        
        [SetUp]
        public void Setup() { }

        [Test]
        public void TestChangeSeq() {
            IEnumerable<int> seq1 = Task61.ArithmeticProgression(-5, 7, 2);
            IEnumerable<int> seqSqr = Task68<int>.ChangeSeq(seq1, Task68<int>.Sqr);
            List<int> expected = new List<int>() {25, 4};
            Assert.AreEqual(expected.Count(), seqSqr.Count());
            int index = 0;
            foreach (var s in seqSqr) {
                Assert.AreEqual(expected[index], s);
                index++;
            }
        }
    }
}