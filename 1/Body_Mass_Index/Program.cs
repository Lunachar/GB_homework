using System;


namespace _2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Заголовок и цвет
            Console.Title = "Михаил Васильев";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            #endregion

            #region Задание
            Console.SetCursorPosition(10, 1);
            Console.WriteLine(@"2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ)
по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.");
            #endregion

            Console.WriteLine("Введите ваш вес, в кг:");
            int int_weight = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост, в см:");
            double int_height = double.Parse(Console.ReadLine());
            int_height = int_height / 100;

            double result = int_weight / (int_height * int_height);

            Console.WriteLine($"Ваш индекс массы тела: {result:F2}");
        }
    }
}