using System;

namespace BrainGames.Games
{
    public static class GeoProgressionGame
    {
        public static bool Start()  // Изменим возвращаемый тип на bool
        {
            Random rnd = new Random();
            int length = rnd.Next(5, 11);
            int step = rnd.Next(2, 5);
            int hiddenIndex = rnd.Next(0, length);

            int[] progression = new int[length];
            progression[0] = rnd.Next(1, 10);

            for (int i = 1; i < length; i++)
            {
                progression[i] = progression[i - 1] * step;
            }

            Console.WriteLine("What number is missing in this progression?");
            for (int i = 0; i < length; i++)
            {
                if (i == hiddenIndex)
                    Console.Write(".. ");
                else
                    Console.Write(progression[i] + " ");
            }
            Console.WriteLine();

            int answer;
            if (!int.TryParse(Console.ReadLine(), out answer))
            {
                Console.WriteLine("Invalid input!");
                return false;  // Возвращаем false, если ввод некорректен
            }

            if (answer == progression[hiddenIndex])
            {
                Console.WriteLine("Correct!");
                return true;  // Возвращаем true, если ответ верный
            }
            else
            {
                Console.WriteLine($"Wrong! The correct answer was {progression[hiddenIndex]}");
                return false;  // Возвращаем false, если ответ неверный
            }
        }
    }
}


