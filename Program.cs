class Program
{
    static void Main()
    {
        while (true)
        {
            Random random = new Random();

            Console.Write("От какого числа мне загадать: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("До какого числа мне загадать: ");
            int end = Convert.ToInt32(Console.ReadLine());
            int step = 0;

            int randomNumber = GenerateRandomNumber(random, start, end);

            Console.WriteLine($"Случайное число от {start} до {end}: {randomNumber}");
            Console.WriteLine("я загадал число, попробуйте его отгадать.");
            while (true)
            {
                Console.Write("Введите число: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                step += 1;

                if (choice == randomNumber)
                {
                    Console.WriteLine("Вы угадали! Число " + randomNumber + ".");
                    Console.WriteLine("Число попыток " + step + ".");
                    Console.WriteLine();
                    Console.WriteLine("Хотите сыграть ещё раз?");
                    string YoN = Console.ReadLine();
                    if (YoN == "yes" || YoN == "y")
                    {
                        break;
                    }

                    Console.WriteLine("Конец.");
                    return;
                }
                else if (choice < randomNumber)
                {
                    Console.WriteLine("Неверный ответ. Число больше.");
                }
                else if (choice > randomNumber)
                {
                    Console.WriteLine("Неверный ответ. Число меньше.");
                }
            }
        }

        static int GenerateRandomNumber(Random random, int start, int end)
        {
            return random.Next(start, end + 1);
        }
    }
}
