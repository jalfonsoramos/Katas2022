using System;
using System.Linq;

namespace NarcissisticNumber;

public class Kata
{
    public static bool Narcissistic(int value)
    {
        var digits = value
                        .ToString()
                        .ToArray()
                        .Select(x => Int32.Parse(x.ToString()));

        var sum = digits.Sum(d => Math.Pow(d,digits.Count()));

        return sum == value;
    }
}