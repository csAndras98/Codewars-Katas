using System;
public static class JadenCase
{
    public static string ToJadenCase(this string phrase)
    {
        char[] chars = phrase.ToCharArray();
        chars[0] = char.ToUpper(chars[0]);
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i].Equals(' '))
            {
                chars[i + 1] = char.ToUpper(chars[i + 1]);
            }
        }
        return string.Join("", chars);
    }
}