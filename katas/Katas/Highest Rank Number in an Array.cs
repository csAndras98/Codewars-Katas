using System.Linq;
public class Kata
{
    public static int HighestRank(int[] arr)
    {
        return arr.GroupBy(x => x).OrderBy(g => g.Count()).ThenBy(g => g.Key).Last().Key;
    }
}