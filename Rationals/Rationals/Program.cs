using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rationals
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var R1 = new Rational(4, 6);
            var R2 = new Rational(12, 6);
            var R3 = new Rational(4);
            var R4 = new Rational(6, 33);
            var R5 = new Rational(10, 9);
            var R6 = new Rational();
            var R7 = new Rational();

            var R = new Rational();

            //Value as double
            Console.WriteLine(R1.valueAsDouble());

            //Add
            R6=R.Add(R1, R2);
            Console.WriteLine(R6.valueAsDouble());

            //Mul
            R7 = R.Mul(R3,R4);
            Console.WriteLine(R7.valueAsDouble());

            //Reduce
            R4.Reduce(R4);

        }
    }


    struct Rational
    {
        int _numerator;
        int _denomerator;

        public Rational(int n, int d)
        {
            _numerator = n;
            _denomerator = d;
        }

        public Rational(int n)
        {
            _numerator = n;
            _denomerator = 1;
        }

        public int numerator()
        {
            return _numerator;
        }

        public int denomerator()
        {
            return _denomerator;
        }

        public double valueAsDouble()
        {
            return (double)_numerator / (double)_denomerator;
        }

        public Rational Add(Rational ab, Rational cd)
        {
            var a = ab.numerator();
            var b = ab.denomerator();
            var c = cd.numerator();
            var d = cd.denomerator();

            int sumN = ((a * d) + (b * c));
            int sumD = (b * d);
            var r = new Rational(sumN, sumD);
            return r;
        }

        public Rational Mul(Rational ab, Rational cd)
        {
            var a = ab.numerator();
            var b = ab.denomerator();
            var c = cd.numerator();
            var d = cd.denomerator();

            int sumN = (a * c);
            int sumD = (b * d);
            var r = new Rational(sumN, sumD);
            return r;
        }

        public void Reduce(Rational ab)
        {
            var a = ab.numerator();
            var b = ab.denomerator();
            int max = Math.Max(a, b);

            for (int i = max; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    a = a / i;
                    b = b / i;
                }
            }
            Console.WriteLine("a:{0},b:{1}", a, b);
        }

    }
}
