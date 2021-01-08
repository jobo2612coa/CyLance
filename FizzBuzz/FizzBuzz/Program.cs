using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // interate from 1 to 100
            // print every number except . .  
            //  div by 3 print fizz
            // ==5 print buzz
            // yes print both
            // Console.WriteLine("Hello World!");

            // refactor reusable class library
            // 


            FizzBuzzPair[] newPairs = new FizzBuzzPair[]
            {
                new FizzBuzzPair(6, "Foo"),
                new FizzBuzzPair(9, "Bar")
            };

            FizzBuzzRun FizzBuzz = new FizzBuzzRun();
          Console.WriteLine(FizzBuzz.Run());    // basic test
            Console.WriteLine(FizzBuzz.Run(16));  // test of upper
            
            FizzBuzzRun FizzBuzz2 = new FizzBuzzRun(newPairs);  //change the pairs
            Console.WriteLine(FizzBuzz2.Run());  //basic test with new pairs
            Console.WriteLine(FizzBuzz2.Run(18, 37));       // test of both upper and lower


            FizzBuzzPair[] newPairs3 = new FizzBuzzPair[]
            {
                new FizzBuzzPair(1, "Concat"),
                new FizzBuzzPair(2, "This")
            };
            FizzBuzzRun FizzBuzz3 = new FizzBuzzRun(newPairs3);  //change the pairs
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(FizzBuzz3.Step(i));   //  test of Step entry point
            }
            Console.WriteLine();

            // edge cases
            string value = "";
            value = FizzBuzz.Run(-16, 0);   // negatives.         and also tests zero   
            Console.WriteLine(value);

            value = FizzBuzz.Run(0, 0);   //  one item list
            Console.WriteLine(value);

            FizzBuzzPair[] noPairs = new FizzBuzzPair[]    // there are no pairs in the list
            {
            };
            FizzBuzzRun noBuzz = new FizzBuzzRun(noPairs);
            value = noBuzz.Run(5);      // there are no pairs in the list
            Console.WriteLine(value);
        }
    }
}
