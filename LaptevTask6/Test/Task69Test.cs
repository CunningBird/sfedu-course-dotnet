using System;
using System.Collections.Generic;
using System.Linq;
using Library;
using NUnit.Framework;

namespace Test
{
    public class Task69Test {
        
        [SetUp]
        public void Setup() { }

        [Test]
        public void TestShiftSeq() {
            IEnumerable<int> seq1 = Task61.ArithmeticProgression(-5, 7, 2);
            IEnumerable<int> seq2 = Task61.ArithmeticProgression(5, 4, 4);
            IEnumerable<int> sss = Task69<int>.ShiftSeq(seq1, seq2);
            List<int> expected = new List<int>() {-5, 5, 2, 9, 13, 17};
            int index = 0;
            Assert.AreEqual(expected.Count(), sss.Count());
            foreach (var item in sss) {
                Assert.AreEqual(expected[index], item);
                index++;
            }
        }
    }
}