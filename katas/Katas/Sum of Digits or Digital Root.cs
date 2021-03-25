using System.Collections.Generic;
using System.Linq;

public class Number
{
    public int DigitalRoot(long n)
    {
        string num = n.ToString();
        while (num.Length > 1)
        {
            List<int> digits = new List<int>();
            foreach (char digit in num)
            {
                digits.Add(digit - '0');
            }
            num = digits.Sum(digit => digit).ToString();
        }
        return int.Parse(num);
    }
}