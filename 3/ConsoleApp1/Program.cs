namespace HomeWork3
{


struct Complex
{
    public double im;
    public double re;
    //  в C# в структурах могут храниться также действия над данными
    public Complex Plus(Complex x)
    {
        Complex y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }
    //  Пример произведения двух комплексных чисел
    public Complex Multi(Complex x)
    {
        Complex y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }
    public Complex Minus(Complex x)
    {
        Complex y;
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }
    public string ToString()
    {
        return re + "+" + im + "i";
    }
}


class Program
{
        static void Main(string[] args)
    {
        do
        {
            Vasiljev_myGB_Utils.greetingsText("Васильев Михаил", "Задание 3.");
            Console.WriteLine("Выберите пункт:");
            Console.WriteLine(@"1 - а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
в) Добавить диалог с использованием switch демонстрирующий работу класса.");
            Console.WriteLine("2 - С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.");
                Console.WriteLine(@"3 - * Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
* Добавить свойства типа int для доступа к числителю и знаменателю;
*Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
**Добавить проверку, чтобы знаменатель не равнялся 0.Выбрасывать исключение ArgumentException(Знаменатель не может быть равен 0);");
            Console.WriteLine("0 - Выход.");



            int menu = Convert.ToInt16(Console.ReadLine());

            switch (menu)
            {
                case 1:
                        Vasiljev_myGB_Utils.greetingsText("Васильев Михаил", "Задание 3.", @"1 - а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.

Выберите пункт а или б:");
                    string punkt = Console.ReadLine();

                    switch (punkt)
                    {
                        case "а":
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Вы выбрали 'а' С использованием структуры ");
                            Console.WriteLine();
                            Console.ResetColor();

                            Complex complexNum1;
                            Console.WriteLine("Введите действительную часть первого комплексного числа:");
                            complexNum1.re = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите мнимую часть первого комплексного числа:");
                            complexNum1.im = int.Parse(Console.ReadLine());

                            Complex complexNum2 = new Complex();
                            Console.WriteLine("Введите действительную часть второго комплексного числа:");
                            complexNum2.re = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите мнимую часть второго комплексного числа:");
                            complexNum2.im = int.Parse(Console.ReadLine());

                            Complex result = complexNum1.Minus(complexNum2);
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"Ответ:  {result.ToString()}");
                            Console.ResetColor();
                                Vasiljev_myGB_Utils.Pause();
                            break;

                        case "б":
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Вы выбрали 'б' С использованием класса ");
                            Console.WriteLine();
                            Console.ResetColor();

                            Complex2 classNum1 = new Complex2();
                            Console.WriteLine("Введите действительную часть первого комплексного числа:");
                            classNum1.re = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите мнимую часть первого комплексного числа:");
                            classNum1.im = int.Parse(Console.ReadLine());

                            Complex2 classNum2 = new Complex2();
                            Console.WriteLine("Введите действительную часть второго комплексного числа:");
                            classNum2.re = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите мнимую часть второго комплексного числа:");
                            classNum2.im = int.Parse(Console.ReadLine());

                            Complex2 result2 = classNum1.Minus(classNum2);
                            Complex2 result3 = classNum1.Multi(classNum2);
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"вычитание. ответ:  {result2.ToString()}");
                            Console.WriteLine($"умножение. ответ:  {result3.ToString()}");
                            Console.ResetColor();
                            Vasiljev_myGB_Utils.Pause();

                            break;

                        default:
                            break;
                    }
                        break;


                case 2:
                        Vasiljev_myGB_Utils.greetingsText("Васильев Михаил", "Задание 3.", $"С клавиатуры вводятся числа, пока не будет введён 0(каждое число в новой строке). \n Требуется подсчитать сумму всех нечётных положительных чисел. \n Сами числа и сумму вывести на экран, используя tryParse.");
                        int input;
                        int score = 0;
                        int into;
                        string inputStr;
                        string numbers = "";

                        while (true)
                        {

                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("");
                            Console.WriteLine("Введите число");
                            Console.ResetColor();
                            inputStr = Console.ReadLine();
                            bool succsess = int.TryParse(inputStr, out input);
                            if (succsess)
                            {
                                if (input > 0 & input % 2 == 1)
                                {
                                    into = input;
                                    numbers += " " + into;
                                                                        
                                }
                                else
                                {
                                    into = 0;
                                }
                                score = score + into;
                                Console.BackgroundColor = ConsoleColor.Yellow;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.WriteLine($"Числа: {numbers}");                                
                                Console.WriteLine($"Сумма чисел = {score}");
                                Console.ResetColor();

                                if (input == 0)
                                {
                                    Console.WriteLine("Вы ввели 0. Выход. нажмите любую клавишу");
                                    

                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Вы ввели не число");
                            }                         


                        }
                        Vasiljev_myGB_Utils.Pause();

                        break;

                    case 3:
                        Vasiljev_myGB_Utils.greetingsText("Васильев Михаил", "Задание 3.", $"3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.");

                        Console.WriteLine("Введите числитель и знаменатель первого числа. Каждое значение на новой строке:");
                        RationalNumbers one = new RationalNumbers(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                        Console.WriteLine("Введите числитель и знаменатель второго числа. Каждое значение на новой строке:");
                        RationalNumbers two = new RationalNumbers(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                        Console.WriteLine($"Первое число = {one}  второе число = {two}");
                        Console.WriteLine($"Сумма чисел = {one.Plus(two)}");
                        Console.WriteLine($"Разность чисел = {one.Minus(two)}");
                        Console.WriteLine($"Произведение чисел = {one.Mult(two)}");
                        Console.WriteLine($"Деление чисел = {one.Div(two)}");
                        Vasiljev_myGB_Utils.Pause();



                        break;
                    case 0:
                    return;
                default:
                    Console.WriteLine("Неверный выбор!");
                    Vasiljev_myGB_Utils.Pause();
                    break;

            }
        }
        while (true);

    }
}
}