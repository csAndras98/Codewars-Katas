using System;

public class Kata
{
    public static string CatMouse(string x)
    {
        if (x.Length > 5)
        {
            return "Escaped!";
        }
        return "Caught!";
    }
}
