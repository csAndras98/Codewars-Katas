using System;
using System.Collections.Generic;

public class StockList
{
    public static string stockSummary(String[] lstOfArt, String[] lstOf1stLetter)
    {
        if (lstOfArt.Length == 0 || lstOf1stLetter.Length == 0)
        {
            return string.Empty;
        }
        int amount = 0;
        string result = "";

        foreach (string order in lstOf1stLetter)
        {
            foreach (string art in lstOfArt)
            {
                if (order[0].Equals(art[0]))
                {
                    amount += int.Parse(art.Split(' ')[1]);
                }
            }
            if (!String.IsNullOrEmpty(result))
            {
                result += " - ";
            }
            result += $"({order} : {amount})";
            amount = 0;
        }
        return result;
    }
}