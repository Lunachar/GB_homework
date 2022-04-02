using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
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
            Console.WriteLine(@" 
а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). 
Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой)

б) * Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
");
            #endregion

            #region Ввод данных
            Console.WriteLine("a) Введите значение x1:");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y1:");
            int y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение x2:");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение y2:");
            int y2 = int.Parse(Console.ReadLine());
            #endregion

            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"{result:F2}");
                

            Console.WriteLine(@"б) Введите значения х1 у1 х2 у2 через запятую:");
            string xy = Console.ReadLine();

            // Создаем разделитель для массива и массив из введенных данных(для тренировки)
            char divider = ',';
            string[] xyArray = xy.Split(divider);

            Console.WriteLine($"Вывод результата используя метод: {Distance(Convert.ToInt16(xyArray[0]), Convert.ToInt16(xyArray[1]), Convert.ToInt16(xyArray[2]), Convert.ToInt16(xyArray[3])):F2}");
        }

        /// <summary>
        /// метод distance
        /// </summary>
        /// <param name="x1">x1</param>
        /// <param name="y1">y1</param>
        /// <param name="x2">x2</param>
        /// <param name="y2">y2</param>
        /// <returns></returns>
        #region Метод distance
        static double Distance(int x1, int y1, int x2, int y2)
        {
            double result_method = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return result_method;
        }
        #endregion
    }
}
