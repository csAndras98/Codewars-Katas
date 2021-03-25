namespace Solution
{
    using System;
    public static class Kata
    {
        public static Tuple<char?, int> LongestRepetition(string input)
        {
            (char?, int) longest = (null, 0);
            (char?, int) current = (null, 0);

            foreach (char letter in input)
            {
                if (current.Item1 == letter)
                {
                    current.Item2++;
                }
                else
                {
                    current = (letter, 1);
                }
                if (current.Item2 > longest.Item2)
                {
                    longest = current;
                }
            }

            return Tuple.Create(longest.Item1, longest.Item2);
        }
    }
}