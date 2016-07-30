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

            Rational num1 = new Rational(1, 2);
            Rational num2 = new Rational(1, 2);

            Rational num3 = num1.Add(num1, num2);

            Rational num4 = num2.Mul(num2, num2);

            Rational num6 = new Rational(2, 4);
            Rational num7 = new Rational(2, 4);
            num7.Reduce(num7);


            Console.WriteLine($"{num1} + {num2} = {num3}");
            Console.WriteLine($"{num2} * {num2} = {num4}");
            Console.WriteLine($"{num6} reduced {num7}");

        }
    }

    //Consider extracting this to a different file.
    //No Euals
    //No ToString
    struct Rational
    {
        int _numerator;
        int _denomerator;

        public Rational(int n, int d)
        {
            _numerator = n;
            _denomerator = d;
        }

        //Consider using hte other construct
        //Rational(int n) : this(n, 1) { }
        public Rational(int n)
        {
            _numerator = n;
            _denomerator = 1;
        }

        //This should be a Property: int Numerator { get { return _numerator; }}
        //Should start with a capital letter
        public int numerator()
        {
            return _numerator;
        }

        //This should be a Property: int Denomerator { get { return _denomerator; }}
        //Should start with a capital letter
        public int denomerator()
        {
            return _denomerator;
        }

        //This should be a Property: int Numerator { get { return _numerator; }}
        //Should start with a capital letter
        //The name 'Value' might have been better
        public double valueAsDouble()
        {
            return (double)_numerator / (double)_denomerator;
        }

        //Why is this getting two arguments?
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

        //Why is this getting two arguments?
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

        //Why is this getting an argument?
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

            //ab or any other Rational instance is not being changed. 
            Console.WriteLine("a:{0},b:{1}", a, b);
        }

    }
}
