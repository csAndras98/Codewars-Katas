using System;

class Arge
{

    public static int NbYear(int p0, double percent, int aug, int p)
    {
        // your code
        int years = 0;
        while (p0 < p)
        {
            years++;
            p0 += (int)(p0 * percent / 100) + aug;
        }
        return years;
    }
}