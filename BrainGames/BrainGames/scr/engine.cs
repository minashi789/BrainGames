using System;

namespace BrainGames
{
    public static class Engine
    {
        public static void Run(Func<bool> game)
        {
            const int maxRounds = 3;

            for (int i = 0; i < maxRounds; i++)
            {
                if (!game())
                {
                    Console.WriteLine("Game over!");
                    return;
                }
            }

            Console.WriteLine("You won!");
        }
    }
}

