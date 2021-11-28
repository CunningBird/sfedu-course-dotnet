using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Library;

namespace Test
{
    public class Task61Test {
        
        [SetUp]
        public void Setup() { }

        [Test]
        public void TestArithmeticProgression() {
            int index = 0;
            IEnumerable<int> progression1 = Task61.ArithmeticProgression(-1, 2, 6);
            List<double> progressionExpected1 = new List<double>() {-1, 1, 3, 5, 7, 9};
            foreach (double d in progression1) {
                Assert.AreEqual(progressionExpected1[index], d);
                index++;
            }

            Assert.AreEqual(6, index);
            Assert.AreEqual(progression1.Count(), index);

            index = 0;
            IEnumerable<double> progression2 = Task61.ArithmeticProgression(3.14, 1, 1);
            List<double> progressionExpected2 = new List<double>() {3.14};
            foreach (double d in progression2) {
                Assert.AreEqual(progressionExpected2[index], d);
                index++;
            }

            Assert.AreEqual(1, index);
            Assert.AreEqual(progression2.Count(), index);

            index = 0;
            IEnumerable<double> progression3 = Task61.ArithmeticProgression(-5.0, -0.5, 7);
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