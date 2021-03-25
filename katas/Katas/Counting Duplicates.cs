using System;
using System.Collections.Generic;

public class Kata
{
    public static int DuplicateCount(string str)
    {
        HashSet<char> characters = new HashSet<char>();
        HashSet<char> duplicates = new HashSet<char>();

        foreach (char character in str)
        {
            if (!characters.Add(char.ToLower(character)))
            {
                duplicates.Add(character);
            }
        }
        return duplicates.Count;
    }
}