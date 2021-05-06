using System;
using System.Collections.Generic;

public class Kata
{
    public static int TripleDouble(long num1, long num2)
    {
        //code me ^^
        string nums = "0123456789";
        foreach (char num in nums)
        {
            if (num1.ToString().Contains(new string(num, 3)) && num2.ToString().Contains(new string(num, 2)))
            {
                return 1;
            }
        }
        return 0;
    }
}