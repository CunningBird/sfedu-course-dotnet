using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Library;
using NUnit.Framework;

namespace Test
{
    public class Task64aTest {
        
        [SetUp]
        public void Setup() { }

        [Test]
        public void FibonacciNumberSequence() {
            int i = 0;
            List<int> seqCorrect = new List<int>() {0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55};
            IEnumerable<int> seqTest = Task64a.FibonacciNumberSequence().Take(seqCorrect.Count);
            foreach (var num in seqTest) {
                Assert.AreEqual(seqCorrect[i], num);
                i++;
            }

            Assert.AreEqual(seqCorrect.Count, i);
            Assert.AreEqual(seqTest.Count(), i);
        }
        
        [Test]
        public void FibonacciNumberSequenceWithN() {
            int i = 0;
            List<int> seqCorrect = new List<int>() {377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368};

            IEnumerable<int> seqTest = Task64a.FibonacciNumberSequence(14).Take(seqCorrect.Count);
            foreach (var num in seqTest) { 
                Assert.AreEqual(seqCorrect[i], num);
                i++;
            }

            Assert.AreEqual(seqCorrect.Count, i);
            Assert.AreEqual(seqTest.Count(), i);
        }
    }
}