
namespace HomeWork3
{
    internal class Vasiljev_myGB_Utils
    {
        #region tapToExit Выход! Нажмите любую клавишу!
        /// <summary>
        /// Выход! Нажмите любую клавишу!
        /// </summary>
        public static void tapToExit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Выход! Нажмите любую клавишу!");
            Console.ResetColor();
            Console.ReadLine();
        }
        #endregion

        #region greetingsText Фамилия Имя студента и номер домашнего задания
        public static void greetingsText(string a, string b)
        {
            Console.Clear();
            Console.Title = $"{a} : {b}";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("==============================");
            Console.WriteLine($"|       {a}      |");
            Console.WriteLine("==============================");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(b);
            Console.ResetColor();
            Console.WriteLine("-----");
            Console.WriteLine();
        }
        #endregion

        #region greetingsText Фамилия Имя студента, номер домашнего задания и номер задачи
        public static void greetingsText(string a, string b, string c)
        {
            Console.Title = $"{a} : {b}";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("==============================");
            Console.WriteLine($"|       {a}      |");
            Console.WriteLine("==============================");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(c);
            Console.ResetColor();
            Console.WriteLine("-----");
            Console.WriteLine();
        }
        #endregion

        #region Pause
        public static void Pause()
        {
            Console.WriteLine("Нажмите Enter чтобы продолжить");
            Console.ReadLine();
        }
        #endregion

        #region PrintInCenter Вывод текста в центре консоли
        public static void PrintInCenter(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.WindowHeight / 2 - 1);
            Console.WriteLine(text);
        }
        #endregion

        #region IsOdd Проверка на четность
        public static bool IsOdd(int n)
        {
            return n % 2 == 0;
        }
        #endregion
    }
}
