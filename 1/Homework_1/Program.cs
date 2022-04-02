using System;


namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Заголовок и цвет
            Console.Title = "Михаил Васильев";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Beep(570, 700);
            Console.Beep(370, 400);
            Console.Beep(570, 700);
            #endregion

            #region Задание
            Console.SetCursorPosition(10, 1);
            Console.WriteLine("Написать программу «Анкета».");
Console.WriteLine(@"Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
В результате вся информация выводится в одну строчку");
            #endregion
            
            Console.WriteLine("Введите ваше имя, фамилию, возраст, рост и вес. В одну строчку, через пробел или запятую:");
            string data = Console.ReadLine();

            // Создаем разделители для массива и массив из введенных данных
            char[] dividers = { ' ', ',' };
            string[] dataArray = data.Split(dividers);

            Console.WriteLine("Имя " + dataArray[0] + "\n" + "Фамилия " + dataArray[1] + "\n" + "Возраст " +
                              dataArray[2] + "\n" + "Рост " + dataArray[3] + "\n" + "Вес " + dataArray[4] + "\n");

            // Форматированный вывод
            Console.WriteLine("Форматированный вывод: {0} {1} {2} {3} {4}", dataArray[0], dataArray[1], dataArray[2], dataArray[3], dataArray[4]);

            // Интерполяция
            Console.WriteLine($"Интерполяция: {dataArray[0]} {dataArray[1]} {dataArray[2]} {dataArray[3]} {dataArray[4]}");
        }
    }
}
