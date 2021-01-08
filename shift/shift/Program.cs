using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shift
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 13 ;
            int Y = 1000;
            int[] A = { 100, 63, 1, 6, 2, 13 };

            // System.Diagnostics.Stopwatch.StartNew();
            int answer = solution(X, Y, A);
            // long timer = System.Diagnostics.Stopwatch.GetTimestamp();
            Console.WriteLine("answer is {0}", answer);
            // Console.WriteLine("time is {0}", timer);
            Console.ReadLine();

        }

        private static int solution(int X, int Y, int[] A)
        {
            int N = A.Length;
            int result = -1;
            int nX = 0;
            int nY = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] == X)
                    nX += 1;
                else if (A[i] == Y)
                    nY += 1;
                if (nX == nY)
                    result = i;
                else if (nX == 0 || nY == 0)
                    result = -1;
            }
            return result;
        }



        private static int solution3(int A, int B, int K)
        {
            int result = 0;
            if ((B % K == 0) && (A % K == 0)) result++;
            result += (B - A + 1) / K;
            return result;
        }

        private static int solution2(int A, int B, int K)
        {
            int result = 0;
            for (int i = A; i <= B; i++)
            {
                if (i % K == 0)
                {
                    result++;
                }
            }
            return result;
        }

        private static int solution1(int[] A)
        {
            int[] found = new int[A.Length+2];
            foreach (int element in A)
            {
                found[element] = 1;
            }
            for (int i = 1; i < found.Length + 1; i++)
            {
                if (found[i] == 0)
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
