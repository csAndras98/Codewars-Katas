using System;
using System.Collections.Generic;
using System.Text;

namespace katas.Katas
{
    class WhichAreIn
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            Array.Sort(array1);
            var r = new List<string>();
            foreach (string word1 in array1)
            {
                foreach (string word2 in array2)
                {
                    if (word2.Contains(word1))
                    {
                        r.Add(word1);
                        break;
                    }
                }
            }
            return r.ToArray();
        }
    }
}
