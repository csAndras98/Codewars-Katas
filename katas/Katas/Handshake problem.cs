using System;

public static class Kata
{
    public static int GetParticipants(int handshakes)
    {
        int x = (int)Math.Sqrt(handshakes * 2) + 1;

        if (x * (x - 1) != handshakes * 2) x++;
        return x;
    }
}