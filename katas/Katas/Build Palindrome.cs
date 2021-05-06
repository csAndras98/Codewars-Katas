using System.Linq;

namespace myjinxin
{
    using System;

    public class Kata
    {
        public string BuildPalindrome(string str)
        {
            //coding and coding..
            string palindrome = str;

            for (int i = 0; i < str.Length; i++)
            {
                if (palindrome.SequenceEqual(palindrome.Reverse()))
                {
                    break;
                }
                palindrome = palindrome.Insert(palindrome.Length - i, str[i].ToString());
            }
            return palindrome;
        }
    }
}
