using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Library;
using NUnit.Framework;

namespace Test
{
    public class Task63Test {
        
        [SetUp]
        public void Setup() { }

        [Test]
        public void InfiniteRandomNumberSequenceNoArgs() {
            int i = 0;
            int count = 30;
            IEnumerable<int> seqTest = Task63.InfiniteRandomNumberSequence().Take(count);
            foreach (var rnd in seqTest) {
                Assert.IsTrue(rnd >= Int32.MinValue && rnd <= Int32.MaxValue);
                i++;
            }

            Assert.AreEqual(count, i);
            Assert.AreEqual(seqTest.Count(), i);
        }

        [Test]
        public void InfiniteRandomNumberSequenceInt() {
            int i = 0;
            int counter = 5;
            int min = -1001;
            int max = 3872;
            IEnumerable<int> seqTest1 = Task63.InfiniteRandomNumberSequence(min, max).Take(counter);
            foreach (var rnd in seqTest1) {
                Assert.IsTrue(rnd.GetType() == typeof(int));
                Assert.IsTrue(rnd >= min && rnd <= max);
                i++;
            }
            
            Assert.AreEqual(counter, i);
            Assert.AreEqual(seqTest1.Count(), i);
            Assert.Throws<ArgumentOutOfRangeException>(() => Task63.InfiniteRandomNumberSequencePrint(10, max, min));
        }  

        [Test]
        public void InfiniteRandomNumberSequenceDouble() {
            int i = 0;
            int counter = 29;
            double min = -2842.24;
            double max = 3943.243;
            IEnumerable<double> seqTest1 = Task63.InfiniteRandomNumberSequence(min, max).Take(counter);
            foreach (var rnd in seqTest1) {
                Assert.IsTrue(rnd.GetType() == typeof(double));
                Assert.IsTrue(rnd >= min && rnd <= max);
                i++;
            }

            Assert.AreEqual(counter, i);
            Assert.AreEqual(seqTest1.Count(), i);
            
            i = 0;
            counter = 20;
            min = -2842.242;
            max = 3500;
            IEnumerable<double> seqTest2 = Task63.InfiniteRandomNumberSequence(min, max).Take(counter);
            foreach (var rnd in seqTest2) {
                Assert.IsTrue(rnd.GetType() == typeof(double));
                Assert.IsTrue(rnd >= min && rnd <= max);
                i++;
            }

            Assert.AreEqual(counter, i);
            Assert.AreEqual(seqTest2.Count(), i);
            
            i = 0;
            counter = 35;
            min = -2000;
            max = 4932.234;
            IEnumerable<double> seqTest3 = Task63.InfiniteRandomNumberSequence(min, max).Take(counter);
            foreach (var rnd in seqTest3) {
                Assert.IsTrue(rnd.GetType() == typeof(double));
                Assert.IsTrue(rnd >= min && rnd <= max);
                i++;
            }

            Assert.AreEqual(counter, i);
            Assert.AreEqual(seqTest3.Count(), i);
            
            min = 20.24;
            max = 39.42;
            Assert.Throws<ArgumentOutOfRangeException>(() => Task63.InfiniteRandomNumberSequencePrint(10, max, min));
        }  
    }
}