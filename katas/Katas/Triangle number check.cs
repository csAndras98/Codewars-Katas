using System;

public class TriangleNumbers
{

    public static bool isTriangleNumber(long number)
    {
        return Math.Sqrt(8 * number + 1) % 1 == 0;
    }
}