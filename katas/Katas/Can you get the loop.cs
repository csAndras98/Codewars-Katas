using System.Collections.Generic;

public class Kata
{
    public static int getLoopSize(LoopDetector.Node startNode)
    {

        HashSet<LoopDetector.Node> previousNodes = new HashSet<LoopDetector.Node>();

        while (previousNodes.Add(startNode))
        {
            startNode = startNode.next;
        }

        int size = 1;
        LoopDetector.Node currentNode = startNode;

        while (currentNode.next != startNode)
        {
            size++;
            currentNode = currentNode.next;
        }

        return size;
    }
}