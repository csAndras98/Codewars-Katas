using System;
using System.Collections.Generic;
using System.Text;

namespace katas.Katas
{
    using System;

    static class Kata
    {
        public static int Hanoi(int disks)
        {
            int moves = 0;
            for (int i = 0; i < disks; i++)
            {
                moves = moves * 2 + 1;
            }
            return moves;
        }
    }
}
