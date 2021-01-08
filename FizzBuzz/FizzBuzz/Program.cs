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


            
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(FizzBuzz.Step(i));   //  test of Step entry point
            }


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
