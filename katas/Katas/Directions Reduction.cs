using System;
using System.Collections.Generic;

public class DirReduction
{
    public static String[] dirReduc(String[] arr)
    {
        Stack<String> stack = new Stack<String>();

        foreach (String direction in arr)
        {
            String lastElement = stack.Count > 0 ? stack.Peek().ToString() : null;

            switch (direction)
            {
                case "NORTH": if ("SOUTH".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                case "SOUTH": if ("NORTH".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                case "EAST": if ("WEST".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
                case "WEST": if ("EAST".Equals(lastElement)) { stack.Pop(); } else { stack.Push(direction); } break;
            }
        }
        String[] result = stack.ToArray();
        Array.Reverse(result);

        return result;
    }
}