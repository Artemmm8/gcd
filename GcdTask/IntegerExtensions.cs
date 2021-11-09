using System;

namespace GcdTask
{
    public static class IntegerExtensions
    {
        public static int FindGcd(int a, int b)
        {
            if (a == 0 && b == 0)
            {
                throw new ArgumentException($"{nameof(a)} and {nameof(b)} are 0 at the same time");
            }

            if (a == int.MinValue || b == int.MinValue)
            {
                throw new ArgumentOutOfRangeException($"{nameof(a)} or {nameof(b)} or both are int.MinValue");
            }

            if (a < 0)
            {
                a *= -1;
            }

            if (b < 0)
            {
                b *= -1;
            }

            int t;
            while (b != 0)
            {
                t = b;
                b = a % b;
                a = t;
            }

            return a;
        }
    }
}
