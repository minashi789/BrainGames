using System;

namespace BrainGames.Games
{
    public static class LcmGame
    {
        public static bool Start()  // Изменим возвращаемый тип на bool
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 100);
            int num2 = rnd.Next(1, 100);
            int num3 = rnd.Next(1, 100);

            Console.WriteLine($"Find the Least Common Multiple of: {num1}, {num2}, {num3}");

            int answer;
            if (!int.TryParse(Console.ReadLine(), out answer))
            {
                Console.WriteLine("Invalid input!");
                return false;  // Возвращаем false, если пользователь ввёл некорректное значение
            }

            int correctAnswer = Lcm(Lcm(num1, num2), num3);

            if (answer == correctAnswer)
            {
                Console.WriteLine("Correct!");
                return true;  // Возвращаем true, если ответ верный
            }
            else
            {
                Console.WriteLine($"Wrong! The correct answer was {correctAnswer}");
                return false;  // Возвращаем false, если ответ неверный
            }
        }

        private static int Lcm(int a, int b)
        {
            return Math.Abs(a * b) / Gcd(a, b);
        }

        private static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}
