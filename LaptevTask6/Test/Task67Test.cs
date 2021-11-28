using System.Collections.Generic;
using System.Linq;
using Library;
using NUnit.Framework;

namespace Test
{
    public class Task67Test {
        
        [SetUp]
        public void Setup() { }

        [Test]
        public void TestFilterEvenSeq() {
            IEnumerable<int> progression = Task61.ArithmeticProgression(-5, 3, 10);
            IEnumerable<int> progressionFilteredEven = Task67.FilteredSeq(progression, Task67.IsEven);
            List<int> expected = new List<int>() {-2, 4, 10, 16, 22};
            Assert.AreEqual(expected.Count(), progressionFilteredEven.Count());
            int index = 0;
            foreach (var number in progressionFilteredEven) {
                Assert.AreEqual(expected[index], number);
                index++;
            }
        }
    }
}