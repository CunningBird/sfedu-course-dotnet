using System;

namespace Fraction {
    public class Frac {
        
        private int a;
        private int b;
        
        private static int GCD(int aInput, int bInput) {
            int a = Math.Abs(aInput);
            int b = Math.Abs(bInput);
            if (a == 0) {
                return b;
            } else {
                while (b != 0) {
                    if (a > b) {
                        a -= b;
                    } else {
                        b -= a;
                    }
                }
                return a;
            }
        }

        public Frac(int a, int b) {
            if (b == 0) {
                throw new DivideByZeroException("b can`t be == 0 !");
            }

            int gcd = GCD(a, b);
            int sign;
            if (b < 0) {
                sign = -1;
            } else {
                sign = 1;
            }

            this.a = sign * a / gcd;
            this.b = sign * b / gcd;
        }

        private int getA {
            get { return a; }
        }

        private int getB {
            get { return b; }
        }

        public static Frac operator +(Frac f1, Frac f2) {
            return new Frac(f1.getA * f2.getB + f2.getA * f1.getB, f1.getB * f2.getB);
        }

        public static Frac operator +(Frac f1, int number) {
            return new Frac(f1.getA + number * f1.getB, f1.getB);
        }

        public static Frac operator +(int number, Frac f1) {
            return f1 + number;
        }

        public static Frac operator -(Frac f1, Frac f2) {
            return new Frac(f1.getA * f2.getB - f2.getA * f1.getB, f1.getB * f2.getB);
        }

        public static Frac operator -(Frac f1, int number) {
            return f1 + (-number);
        }

        public static Frac operator -(int number, Frac f1) {
            return new Frac(number * f1.getB - f1.getA, f1.getB);
        }

        public static Frac operator *(Frac f1, Frac f2) {
            return new Frac(f1.getA * f2.getA, f1.getB * f2.getB);
        }

        public static Frac operator *(int number, Frac f1) {
            return new Frac(number * f1.getA, f1.getB);
        }

        public static Frac operator *(Frac f1, int number) {
            return number * f1;
        }

        public static Frac operator /(Frac f1, Frac f2) {
            return new Frac(f1.getA * f2.getB, f1.getB * f2.getA);
        }

        public static Frac operator /(Frac f1, int number) {
            return new Frac(f1.getA, f1.getB * number);
        }

        public static Frac operator /(int number, Frac f1) {
            return new Frac(number * f1.getB, f1.getA);
        }

        public static bool operator ==(Frac f1, Frac f2) {
            return f1.getA == f2.getA && f2.getB == f1.getB;
        }

        public static bool operator ==(Frac f1, int number) {
            return f1.getA == number && f1.getB == 1;
        }

        public static bool operator !=(Frac f1, Frac f2) {
            return !(f1 == f2);
        }

        public static bool operator !=(Frac f1, int number) {
            return !(f1 == number);
        }

        public static implicit operator double(Frac f) {
            return (double) f.getA / (double) f.getB;
        }

        public static implicit operator Frac(int number) {
            return new Frac(number, 1);
        }

        public override int GetHashCode() => getA.GetHashCode() ^ getB.GetHashCode();

        public override bool Equals(Object o) {
            if (o == null)
                return false;
            if (o.GetType() != GetType())
                return false;
            var frac = o as Frac;
            return frac.getA == getA && frac.getB == getB;
        }
        public override string ToString() => $"Fraction : a={getA} , b={getB}";
    }

    public class Pol {
        public static Frac Polynom(Frac x) {
            return (new Frac(5, 6) * x * x * x * x) - (new Frac(2, 1) * x * x * x) + (new Frac(3, 4) * x * x) - (new Frac(79, 1) * x) + new Frac(9, 10);
        }
    }
}