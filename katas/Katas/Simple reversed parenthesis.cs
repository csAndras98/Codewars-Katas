public class Solution
{
    public static int solve(string s)
    {
        if (s.Length % 2 != 0)
        {
            return -1;
        }
        int c = 0;
        int k = 0;
        foreach (char ch in s)
        {
            if (ch == '(')
                k++;
            else if (k > 0)
                k--;
            else
            {
                k++; c++;
            }
        }
        return c + k / 2;
    }
}
