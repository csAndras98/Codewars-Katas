using System.Text;
using System.Linq;

public class DupEnc
{
    public static string DuplicateEncode(string word)
    {
        word = word.ToLower();
        var sb = new StringBuilder();
        foreach (char chr in word)
        {
            if (word.Count(f => f == chr) == 1)
            {
                sb.Append('(');
            }
            else
            {
                sb.Append(')');
            }
        }
        return sb.ToString();
    }
}