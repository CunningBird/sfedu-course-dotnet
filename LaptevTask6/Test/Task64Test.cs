using System.Collections.Generic;
using System.Linq;
using Library;
using NUnit.Framework;

namespace Test
{
    public class Task64Test {
        
        [SetUp]
        public void Setup() { }

        [Test]
        public void TestInfiniteArithmeticProgression() {
            int index = 0;
            IEnumerable<double> progression1 = Task64.InfiniteArithmeticProgression(-1, 2).Take(6);
            List<double> progressionExpected1 = new List<double>() {-1, 1, 3, 5, 7, 9};
            foreach (double d in progression1) {
                Assert.AreEqual(progressionExpected1[index], d);
                index++;
            }

            Assert.AreEqual(6, index);
            Assert.AreEqual(progression1.Count(), index);

            index = 0;
            IEnumerable<double> progression2 = Task64.InfiniteArithmeticProgression(3.14, 1).Take(1);
            List<double> progressionExpected2 = new List<double>() {3.14};
            foreach (double d in progression2) {
                Assert.AreEqual(progressionExpected2[index], d);
                index++;
            }

            Assert.AreEqual(1, index);
            Assert.AreEqual(progression2.Count(), index);

            index = 0;
            IEnumerable<double> progression3 = Task64.InfiniteArithmeticProgression(-5.0, -0.5).Take(7);
            List<double> progressionExpected3 = new List<double>() {-5, -5.5, -6, -6.5, -7, -7.5, -8};
            foreach (double d in progression3) {
                Assert.AreEqual(progressionExpected3[index], d);
                index++;
            }

            Assert.AreEqual(7, index);
            Assert.AreEqual(progression3.Count(), index);
        }
    }
}