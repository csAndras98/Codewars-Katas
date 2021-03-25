using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static List<string> Anagrams(string word, List<string> words)
    {
        List<string> result = new List<string>();
        char[] letters = word.ToCharArray();
        Array.Sort(letters);
        foreach (string element in words)
        {
            char[] anagram = element.ToCharArray();
            Array.Sort(anagram);
            if (string.Join("", letters).Equals(string.Join("", anagram)))
            {
                result.Add(element);
            }
        }
        return result;
    }
}