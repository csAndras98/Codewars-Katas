using System.Text;

public class Solution
{
    public static string[] dup(string[] arr)
    {
        //..      
        string[] result = new string[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            char last = ' ';
            var sb = new StringBuilder();
            foreach (char letter in arr[i])
            {
                if (!letter.Equals(last))
                {
                    sb.Append(letter);
                    last = letter;
                }
            }
            result[i] = sb.ToString();
        }
        return result;
    }
}