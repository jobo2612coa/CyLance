using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace dynamic_array
{
    class Result
    {

        /*
         * Complete the 'dynamicArray' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER n
         *  2. 2D_INTEGER_ARRAY queries
         */

        public static List<int> dynamicArray(int n, List<List<int>> queries)
        {
            List<int> result = new List<int>(0);

            int lastAnswer = 0;
            int N = n;

            List<List<int>> seqList = new List<List<int>>(N);
            for (int i = 0; i < N; i++)
                seqList.Add(new List<int>());

            List<int> seq = null;

            foreach (List<int> query in queries)
            {

                int Type = query[0];
                int x = query[1];
                int y = query[2];

                int index1 = (x ^ lastAnswer) % N;
                if (Type == 1)
                {
                    seq = seqList[index1];
                    if (seq == null)
                        seq = new List<int>(y);
                    else
                        seq.Add(y);
                }
                else
                {
                    seq = seqList[index1];
                    int size = seq.Count;
                    int index2 = y % size;
                    int element = seq[index2];
                    lastAnswer = element;

                    result.Add(lastAnswer);
                    //Console.WriteLine("{0}", lastAnswer);
                }
            }
            return result;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
//            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            TextWriter textWriter = new StreamWriter("./output.txt", true);

//            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//            int n = Convert.ToInt32(firstMultipleInput[0]);

//            int q = Convert.ToInt32(firstMultipleInput[1]);

//            List<List<int>> queries1 = new List<List<int>>();
            List<List<int>> queries2 = new List<List<int>>();

            //for (int i = 0; i < q; i++)
            //{
            //    queries1.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            //}

            int n = create_n();
            int q = create_q();
            queries2 = create_list();
            List<int> result = Result.dynamicArray(n, queries2);

            textWriter.WriteLine(String.Join("\n", result));

            textWriter.Flush();
            textWriter.Close();

            Console.WriteLine("Done, press <enter> to continue");
            Console.ReadLine();
        }

        static int create_n()
        {
            return 2;
        }
        static int create_q()
        {
            return 5;
        }
        static List<List<int>> create_list()
        {
             List<List<int>> result =  new List<List<int>>();
            int[] array0 = { 1, 0, 5 };
            int[] array1 = { 1, 1, 7 };
            int[] array2 = { 1, 0, 3 };
            int[] array3 = { 2, 1, 0 };
            int[] array4 = { 2, 1, 1 };

            result.Add(array0.ToList());
            result.Add(array1.ToList());
            result.Add(array2.ToList());
            result.Add(array3.ToList());
            result.Add(array4.ToList());

            return result;
        }
    }
}