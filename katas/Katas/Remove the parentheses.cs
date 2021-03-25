using System;
using System.Text;

namespace Solution
{
    public static class Kata
    {
        public static string RemoveParentheses(string s)
        {
            var sb = new StringBuilder();
            int check = 0;
            foreach (char letter in s)
            {
                if (letter.Equals('('))
                {
                    check++;
                    continue;
                }
                if (letter.Equals(')'))
                {
                    check--;
                    continue;
                }
                if (check == 0)
                {
                    sb.Append(letter);
                }
            }
            return sb.ToString();
        }
    }
}