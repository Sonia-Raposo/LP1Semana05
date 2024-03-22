using System;

namespace RanDice
{
    /// <summary>
    /// Accepts 2 int args, first being number of dice and second the seed
    /// After inserted and enter, the result will be printed
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //number of dice
            int n = int.Parse(args[0]);

            //number of seed
            int s = int.Parse(args[1]);


            //random class
            Random random = new Random(s);

            //dice result
            int result = 0;


            for (int i = 0; i < n; i++)
            {
                int randomN = random.Next (1,7);

                result += randomN;
            }

            //print dice result
            Console.WriteLine(result);
        }
    }
}
