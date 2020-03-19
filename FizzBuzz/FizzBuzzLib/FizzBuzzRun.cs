using System;

namespace FizzBuzz
{
    public class FizzBuzzPair
    {
        public int number { get; set; }
        public string replacement { get; set; }
        public FizzBuzzPair (int n, string r)
        {
            number = n;
            replacement = r;
        }
    }
    public class FizzBuzzRun
    {
        /* Options
         * Default 1-100, 3->Fizz 5->Buzz
         * User Upper Limit 
         * User number/replacement pair -- programmer choice - this deletes the original 3/Fizz 5/Buzz pairs TC: 6/Foo 9/Bar
         * Library return #/replacement as generated, rather than batch   --new I/F
         */

        private FizzBuzzPair[] Pairs = new FizzBuzzPair[]
            {
                new FizzBuzzPair(3, "Fizz"),
                new FizzBuzzPair(5, "Buzz")
            };
        public int upper { get; set; }
        public int lower { get; set; }
        public FizzBuzzRun()
        {
            upper = 100;
            lower = 1;
        }
        public FizzBuzzRun(FizzBuzzPair[] pairs)
        {
            Pairs = pairs;
        }


        public string Run()
        {
            return Run(1, 100);
        }
        public string Run(int upper)
        {
            return Run(1, upper);
        }
        public string Run(int lower, int upper) // generate list of all the Fizz Buzz pairs into a string
        {
            #region old code
            /*
            const string fizz = "Fizz";
            const string buzz = "Buzz";
            const string fizzbuzz = "FizzBuzz";
            */
            #endregion
            string result = "";

            for (int i = lower; i <= upper; i++)
            {
                result = String.Concat(result, Step(i));
                result = String.Concat(result, System.Environment.NewLine);
            }
            #region         old code     hardcoded loop    
            /* saved hardcoded loop 
            for (int i = 1; i <= upper; i++)
                {
                    if ((i % 3 == 0) && (i % 5 != 0))
                    {
                        result += fizz + System.Environment.NewLine;

                    }
                    else if ((i % 3 != 0) && (i % 5 == 0))
                    {
                        result += buzz + System.Environment.NewLine;

                    }
                    else if ((i % 3 == 0) && (i % 5 == 0))
                    {
                        result += fizzbuzz + System.Environment.NewLine;

                    }
                    else
                    {
                        result += i + System.Environment.NewLine;

                    }
                }
                */
                #endregion


            return result;
        }
        public string Step (int current)   // Return each pair as generated, rather than composite
        {
            string result = "";
            bool match = false;
            foreach (FizzBuzzPair pair in this.Pairs)
            {
                if (current % pair.number == 0)
                {
                    result = String.Concat(result, pair.replacement);
                    match = true;
                }
            }
            if (!match)
            {
                result = String.Concat(result, current.ToString());
            }
            return result;
        }
    }
}
