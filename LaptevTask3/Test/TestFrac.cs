using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fraction;

namespace Test {
    
    [TestClass]
    public class TestFrac {
        
        [TestMethod]
        public void TestEqual() {
            var frac1 = new Frac(2, 1);
            var frac2 = new Frac(4, 2);
            Assert.AreEqual(frac1, frac2);

            frac1 = 54;
            frac2 = new Frac(54, 1);
            Assert.AreEqual(frac1, frac2);

            double d1 = new Frac(3, 4);
            Assert.AreEqual(d1, 0.75);

            frac1 = new Frac(-2, -1);
            frac2 = new Frac(2, 1);
            Assert.AreEqual(frac1, frac2);

            frac1 = new Frac(2, -1);
            int number = -2;
            frac2 = new Frac(-2, 1);
            Assert.AreEqual(frac1, frac2);
            Assert.AreEqual(number, frac2);
        }

        [TestMethod]
        public void TestSum() {
            var frac1 = new Frac(1, 2);
            var frac2 = new Frac(3, 4);
            int number = 25;
            Assert.AreEqual(new Frac(5, 4), frac1 + frac2);
            Assert.AreEqual(new Frac(103, 4), number + frac2);
            Assert.AreEqual(new Frac(103, 4), frac2 + number);
        }

        [TestMethod]
        public void TestDifference() {
            var frac1 = new Frac(1, 2);
            var frac2 = new Frac(3, 4);
            int number = 2;
            Assert.AreEqual(new Frac(1, 4), frac2 - frac1);
            Assert.AreEqual(new Frac(-1, 4), frac1 - frac2);
            Assert.AreEqual(new Frac(-3, 2), frac1 - number);
            Assert.AreEqual(new Frac(3, 2), number - frac1);
        }

        [TestMethod]
        public void TestMultiplication() {
            var frac1 = new Frac(5, 6);
            var frac2 = new Frac(7, 9);
            int number = 22;
            Assert.AreEqual(new Frac(35, 54), frac2 * frac1);
            Assert.AreEqual(new Frac(55, 3), number * frac1);
            Assert.AreEqual(new Frac(154, 9), number * frac2);
        }

        [TestMethod]
        public void TestDivision() {
            var frac1 = new Frac(98, 99);
            var frac2 = new Frac(35, 36);
            int number = 7;
            Assert.AreEqual(new Frac(56, 55), frac1 / frac2);
            Assert.AreEqual(new Frac(55, 56), frac2 / frac1);
            Assert.AreEqual(new Frac(99, 14), number / frac1);
            Assert.AreEqual(new Frac(14, 99), frac1 / number);
        }

        [TestMethod]
        public void TestPolynom() {
            var frac = new Frac(1, 2);
            Assert.AreEqual(new Frac(-18533, 480), Pol.Polynom(frac));
            frac = new Frac(3, 4);
            Assert.AreEqual(new Frac(-149781, 2560), Pol.Polynom(frac));
            frac = new Frac(-1, 2);
            Assert.AreEqual(new Frac(19627, 480), Pol.Polynom(frac));
            frac = new Frac(-3, 4);
            Assert.AreEqual(new Frac(157899, 2560), Pol.Polynom(frac));
        }
    }
}