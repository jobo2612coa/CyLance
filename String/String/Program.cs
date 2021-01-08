using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "0111001";
            int answer = solution(S);
            Console.WriteLine("answer {0}", answer);
            Console.ReadLine();
        }

        private static int solution(string S)
        {

            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string workstr = S.Substring(0);
            int count = 0;
            bool done = false;
            do
            {
                char lastChar = workstr[workstr.Length - 1];
                if (lastChar == '1')
                {
                    workstr = workstr.Substring(0, workstr.Length - 1) + "0";
                    count++;
                }
                else if (lastChar == '0')
                {
                    workstr = workstr.Substring(0, workstr.Length - 1);
                    count++;
                }
                if (workstr.Length == 1)
                {
                    done = true;
                }
                for (int i = 0; i < workstr.Length - 1; i++)
                {
                    if (workstr[i] == 1)
                    {
                        done = false;
                    }

                }
            } while (!done);
            return count;
        }
    }
}
