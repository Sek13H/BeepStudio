using System;

namespace BeepStudio
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Добро пожаловать в BeepStudio! Введите частоту и длительность через запятую! Напишите exit для выхода!");

            while (true)
            {
                Console.Write("Введите данные:");

                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {

                    break;
                }
                string[] parts = input.Split(',');

                if (parts.Length == 2 && int.TryParse(parts[0], out int frequency) && int.TryParse(parts[1], out int duration))
                {
                    Console.Beep(frequency, duration);
                }
                else
                {
                    Console.WriteLine("Ошибка ввода!");
                }


            }
        }

    }
}