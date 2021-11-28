using System;
using System.Collections.Generic;
using System.Linq;
using Library;
using NUnit.Framework;

namespace Test
{
    public class Task62Test {
        
        [SetUp]
        public void Setup() { }

        [Test]
        public void TestInfiniteSeq() {
            IEnumerable<string> seqString = Task62<string>.InfiniteSeq("Hello, world!");
            IEnumerable<string> seqString7 = Task62<string>.TakeN(seqString, 7);
            int index = 0;
            foreach (var s in seqString7) {
                Assert.AreEqual("Hello, world!", s);
                index++;
            }

            Assert.AreEqual(7, index);
            Assert.AreEqual(seqString7.Count(), index);

            IEnumerable<int> seqInt = Task62<int>.InfiniteSeq(25);
            IEnumerable<int> seqInt1234 = Task62<int>.TakeN(seqInt, 1234);
            index = 0;
            foreach (var number in seqInt1234) {
                Assert.AreEqual(25, number);
                index++;
            }

            Assert.AreEqual(1234, index);
            Assert.AreEqual(seqInt1234.Count(), index);

            try {
                IEnumerable<int> seqIntBadNumber = Task62<int>.TakeN(seqInt, -101101);
            } catch (ArgumentException e) {
                Assert.Pass();
            }
        }
    }
}