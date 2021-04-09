using System;
using System.Linq;

public class Kata
{
    public static string SortTheInnerContent(string words)
    {
        string[] wordArray = words.Split(' ').ToArray();
        for (int i = 0; i < wordArray.Length; i++)
        {
            if (wordArray[i].Length > 2)
            {
                char[] chars = wordArray[i].ToCharArray();
                Array.Sort(chars, 1, (chars.Length - 2));
                Array.Reverse(chars, 1, (chars.Length - 2));
                wordArray[i] = new string(chars);
            }
        }
        return string.Join(' ', wordArray);
    }
}
