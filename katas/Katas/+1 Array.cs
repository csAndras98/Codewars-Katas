using System;
using System.Numerics;
using System.Linq;

namespace Kata
{
    public static class Kata
    {
        public static int[] UpArray(int[] num)
        {
            if (num.Length == 0 || num.Any(x => x < 0 || x > 9))
                return null;
            var firstInt = num[0];
            var result = (BigInteger.Parse(string.Join("", num)) + 1).ToString().Select(x => x - '0').ToList();
            if (firstInt == 0)
                result.Insert(0, firstInt);
            return result.ToArray();
        }
    }
}
