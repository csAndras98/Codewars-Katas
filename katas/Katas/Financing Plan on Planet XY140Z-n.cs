public class Finance
{
    public static ulong finance(ulong n)
    {
        // your code
        ulong sum = 0;
        for (ulong i = 0; i <= n; i++)
        {
            ulong saved = i * 2;
            for (ulong j = i; j <= n; j++)
            {
                sum += saved;
                saved++;
            }
        }
        return sum;
    }
}