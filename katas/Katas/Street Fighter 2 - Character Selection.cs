using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
    {
        var results = new List<string>();
        var row = 0;
        var col = 0;

        foreach (var s in moves)
        {
            switch (s)
            {
                case "up":
                    row -= 1;
                    break;
                case "down":
                    row += 1;
                    break;
                case "left":
                    col -= 1;
                    break;
                case "right":
                    col += 1;
                    break;
            }
            if (row < 0) row = 0;
            if (row == fighters.Length) row--;
            if (col == fighters[0].Length) col = 0;
            if (col == -1) col = fighters[0].Length - 1;

            results.Add(fighters[row][col]);
        }

        return results.ToArray();
    }
}