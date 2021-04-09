public class Kata
{
    public static string Broken(string x)
    {
        char[] chars = x.ToCharArray();
        string result = "";
        foreach (char num in chars)
        {
            if (num.Equals('0'))
            {
                result = result + "1";
            }
            else
            {
                result = result + "0";
            }
        }
        return result;
    }
}
