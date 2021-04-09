using System.Linq;

public class Kata
{
    public static string[] Bald(string x)
    {
        string[] result = new string[2];
        result[0] = x.Replace('/', '-');
        int count = x.Count(f => f == '/');
        if (count > 5)
        {
            result[1] = "Hobo!";
        }
        else if (count == 0)
        {
            result[1] = "Clean!";
        }
        else if (count == 1)
        {
            result[1] = "Unicorn!";
        }
        else if (count == 2)
        {
            result[1] = "Homer!";
        }
        else
        {
            result[1] = "Careless!";
        }
        return result;
    }
}
