using System;

namespace BuildAPileOfCubes;

public class Kata
{
    public static long FindNB(long m)
    {
        long volume = 0;
        long n = 0;

        do
        {
            volume += (long)Math.Pow(++n, 3);
        } while (volume < m);

        return volume == m ? n : -1;
    }
}