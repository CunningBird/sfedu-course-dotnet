using ComplexNs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test {
    
    [TestClass]
    public class TestComplex {
        
        [TestMethod]
        public void TestEqual() {
            Complex c1 = new Complex(2.5, -3.774);
            Complex c2 = new Complex(2.5, -3.774);
            Assert.AreEqual(c1, c2);

            c1 = new Complex(2.556456, -33.774);
            c2 = new Complex(2.51242, -3.7744);
            Assert.AreNotEqual(c1, c2);
        }

        [TestMethod]
        public void TestSum() {
            Complex c1 = new Complex(2.1, -1.5);
            Complex c2 = new Complex(2.2, 2.1);

            Assert.AreEqual(new Complex(4.3, 0.6), c1 + c2);
        }

        [TestMethod]
        public void TestDifference() {
            Complex c1 = new Complex(2.1, -1.5);
            Complex c2 = new Complex(2.2, 2.1);

            Assert.AreEqual(new Complex(-0.1, -3.6), c1 - c2);
            Assert.AreEqual(new Complex(0.1, 3.6), c2 - c1);
        }
    }
}