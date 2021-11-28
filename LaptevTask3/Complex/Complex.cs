using System;
using System.Runtime.Remoting.Proxies;

namespace ComplexNs {
    public class Complex
    {
        private double real;
        private double imaginary;
        private static double eps = 1E-6;

        public Complex(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public double getReal {
            get { return real; }
        }

        public double getImaginary {
            get { return imaginary; }
        }

        public override int GetHashCode() => getReal.GetHashCode() ^ getImaginary.GetHashCode();

        public override bool Equals(Object o) {
            if (o == null)
                return false;
            if (o.GetType() != GetType())
                return false;
            var complex = o as Complex;
            return Math.Abs(complex.getReal - getReal) < eps && Math.Abs(complex.getImaginary - getImaginary) < eps;
        }

        public override string ToString() => $"Complex : real={getReal} , imaginary={getImaginary}";

        public static bool operator ==(Complex c1, Complex c2) {
            return c1.Equals(c2);
        }

        public static bool operator !=(Complex c1, Complex c2) {
            return !(c1 == c2);
        }

        public static Complex operator +(Complex c1, Complex c2) {
            return new Complex(c1.getReal + c2.getReal, c1.getImaginary + c2.getImaginary);
        }

        public static Complex operator -(Complex c1, Complex c2) {
            return new Complex(c1.getReal - c2.getReal, c1.getImaginary - c2.getImaginary);
        }

        public static Complex operator *(Complex c1, Complex c2) {
            return new Complex(
                c1.getReal * c2.getReal - c1.getImaginary * c2.getImaginary,
                c1.getReal * c2.getImaginary + c2.getReal * c1.getImaginary
            );
        }

        public static Complex operator /(Complex c1, Complex c2) {
            return new Complex(
                (c1.getReal * c2.getReal + c1.getImaginary * c2.getImaginary) / (c2.getReal * c2.getReal + c2.getImaginary * c2.getImaginary),
                (c1.getImaginary * c2.getReal - c1.getReal * c2.getImaginary) / (c2.getReal * c2.getReal + c2.getImaginary * c2.getImaginary)
            );
        }
    }
}