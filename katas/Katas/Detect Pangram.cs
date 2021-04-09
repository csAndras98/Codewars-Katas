using System;

public static class Kata
{
    public static bool IsPangram(string str)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        str = str.ToLower();

        foreach (char letter in alphabet)
        {
            if (!str.Contains(letter))
            {
                return false;
            }
        }
        return true;
    }
}
