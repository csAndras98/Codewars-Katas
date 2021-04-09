using System.Collections.Generic;

public class Deadfish
{
    public static int[] Parse(string data)
    {
        // Return the output array, and ignore all non-op characters
        List<int> result = new List<int>();
        int value = 0;
        for (int i = 0; i < data.Length; i++)
        {
            switch (data[i])
            {
                case 'i':
                    value++;
                    break;
                case 'd':
                    value--;
                    break;
                case 's':
                    value = value * value;
                    break;
                case 'o':
                    result.Add(value);
                    break;
                default:
                    break;
            }
        }
        return result.ToArray();
    }
}
