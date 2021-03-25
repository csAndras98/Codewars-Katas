using System.Text;
public class Kata
{
    public static string Rot13(string message)
    {
        // your code here
        string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string abcRot13 = "nopqrstuvwxyzabcdefghijklmNOPQRSTUVWXYZABCDEFGHIJKLM";
        var sb = new StringBuilder();

        foreach (char letter in message)
        {
            if (abc.Contains(letter))
            {
                for (int i = 0; i < abc.Length; i++)
                {
                    if (abc[i].Equals(letter))
                    {
                        sb.Append(abcRot13[i]);
                    }
                }
            }
            else
            {
                sb.Append(letter);
            }
        }
        return sb.ToString();
    }
}