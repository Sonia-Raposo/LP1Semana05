using System;

namespace RanDice
{
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
