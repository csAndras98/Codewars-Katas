public class MaxRotate
{

    public static long MaxRot(long n)
    {
        long max = n;
        string number = n.ToString();
        for (int i = 0; i < number.Length - 1; i++)
        {
            number = number.Substring(0, i) + number.Substring(i + 1) + number[i];
            n = long.Parse(number);
            if (n > max) max = n;
        }
        return max;
    }
}