using System;

public class Kata
{
    public static string ToCamelCase(string str)
    {
        string[] words = str.Split('-', '_');

        for (int i = 1; i < words.Length; i++)
        {
            char[] word = words[i].ToCharArray();
            word[0] = char.ToUpper(word[0]);
            words[i] = string.Join("", word);
        }

        return string.Join("", words);
    }
}