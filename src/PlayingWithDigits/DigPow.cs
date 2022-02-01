using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayingWithDigits
{
    internal class DigPow
    {
        internal static long digPow(int n, int p)
        {
            if (n <= 0 || p <= 0) return -1;

            List<int> digits = n.ToString().ToArray()
                                .Select(c => int.Parse(c.ToString())).ToList();

            long sum = 0;
            int incrementalPow = p;

            digits.ForEach(digit => { sum += (long)Math.Pow(digit, incrementalPow++); });

            return sum >= n && sum % n == 0 ? sum / n : -1;
        }
    }
}