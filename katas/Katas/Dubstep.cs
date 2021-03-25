using System;
using System.Linq;
using System.Text;

public class Dubstep
{
    public static string SongDecoder(string input)
    {
        string[] words = input.Split("WUB");
        string word = string.Join(' ', words);
        var sb = new StringBuilder();
        char last = ' ';
        for (int i = 0; i < word.Length; i++)
        {
            if (!word[i].Equals(' ') || !last.Equals(' '))
            {
                last = word[i];
                sb.Append(word[i]);
            }
        }
        return sb.ToString().Trim();
    }
}
