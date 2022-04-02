using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
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

            int a = 5;
            int b = 7;
            int temp; 


            Console.WriteLine("Обмен значений двух переменных.");
            Console.WriteLine($"Даны две переменные со следующими значениями: a = {a}, b = {b}");

            temp = b;
            b = a;
            a = temp;

            Console.WriteLine($"После обмена, с третьей переменной, значение переменных: a = {a}, b = {b}");
            Console.WriteLine();

            

            int c = 6;
            int d = 8;
            Console.WriteLine($"Обмен значений двух переменных, без использования третьей. с = {c}, d = {d}");

            c = c + d;
            d = c - d;
            c = c - d;
            Console.WriteLine($"После обмена: c = {c}, d = {d}");
        }
    }
}
