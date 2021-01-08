using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

namespace shift
{
    public class Solution
    {
        public int[] solution(int[] A, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int[] result = new int[A.Length];
            if ((K == 0) || (A.Length % K == 0)) { return A; }
            int shiftnum = A.Length > K ? K : A.Length % K;
            Console.WriteLine("shift: {0}", shiftnum);
            return shift(A, shiftnum);

            return result;
        }
        private int[] shift(int[] A, int K)
        {

        }
    }
}
