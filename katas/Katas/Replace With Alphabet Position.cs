using System.Text;

public static class Kata
{
    public static string AlphabetPosition(string text)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string lowerText = text.ToLower();
        var sb = new StringBuilder();
        foreach (char letter in lowerText)
        {
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (letter.Equals(alphabet[i]))
                {
                    sb.Append(i + 1);
                    sb.Append(' ');
                }
            }
        }
        return sb.ToString().Trim();
    }
}