using System.Text;

public class Kata
{
    public static string[] TowerBuilder(int nFloors)
    {
        var sb = new StringBuilder();

        string[] tower = new string[nFloors];

        for (int i = 0; i < tower.Length; i++)
        {
            sb.Append(' ', nFloors - i - 1);
            sb.Append('*', i * 2 + 1);
            sb.Append(' ', nFloors - i - 1);
            tower[i] = sb.ToString();
            sb.Clear();
        }
        return tower;
    }
}