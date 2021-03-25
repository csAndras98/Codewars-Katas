using System.Collections.Generic;

public class SqInRect
{

    public static List<int> sqInRect(int lng, int wdth)
    {

        if (lng == wdth)
        {
            return null;
        }

        List<int> result = new List<int>();

        while (lng != 0 && wdth != 0)
        {
            if (lng > wdth)
            {
                lng -= wdth;
                result.Add(wdth);
            }
            else if (lng < wdth)
            {
                wdth -= lng;
                result.Add(lng);
            }
            else
            {
                result.Add(lng);
                lng = 0;
                wdth = 0;
            }
        }

        return result;
    }
}