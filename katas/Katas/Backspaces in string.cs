using System.Text;

public class Kata
{
    public static string CleanString(string s)
    {
        var sb = new StringBuilder();
        foreach (char letter in s)
        {
            if (letter.Equals('#') && sb.Length > 0)
            {
                sb.Length--;
            }
            else if (!letter.Equals('#'))
            {
                sb.Append(letter);
            }
        }
        return sb.ToString();
    }
}