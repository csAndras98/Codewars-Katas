using System;
using System.Collections.Generic;

class Kata
{
    public static List<int> TreeByLevels(Node node)
    {
        //off ya go!

        List<int> result = new List<int>();

        if (node == null)
        {
            return result;
        }

        Queue<Node> q = new Queue<Node>();

        q.Enqueue(node);

        while (q.Count > 0)
        {
            node = q.Dequeue();
            result.Add(node.Value);

            if (node.Left != null)
            {
                q.Enqueue(node.Left);
            }

            if (node.Right != null)
            {
                q.Enqueue(node.Right);
            }
        }

        return result;
    }
}