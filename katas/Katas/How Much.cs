using System;

public class Carboat
{

    public static string howmuch(int m, int n)
    {
        string str = "[";
        for (int i = Math.Min(m, n); i <= Math.Max(m, n); i++)
        {
            if (i % 9 == 1 && i % 7 == 2)
            {
                str = str + "[M: " + i + " B: " + i / 7 + " C: " + i / 9 + "]";
            }
        }
        return str + "]";
    }
}