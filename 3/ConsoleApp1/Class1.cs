namespace HomeWork3
{
    #region Complex2  Операции с комплексными числами
    internal class Complex2
    {
        public double im;
        public double re;


        public Complex2 Multi(Complex2 x)
        {
            Complex2 z = new Complex2();
            z.im = re * x.im + im * x.re;
            z.re = re * x.re - im * x.im;
            return z;
        }
        public Complex2 Minus(Complex2 x)
        {
            Complex2 z = new Complex2();
            z.im = im - x.im;
            z.re = re - x.re;
            return z;
        }

        public string ToString()
        {
            if (im >= 0)
            {
                return re + "+" + im + "i";
            }
            else
            {
                return re + "" + im + "i";
            }

            
        }
    }
    #endregion

    #region RationalNumbers класс дробей — рациональных чисел
    public class RationalNumbers
    {
        private int num; // числитель
        private int denom; // знаменатель

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public int Denom
        {
            get { return denom; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может равняться 0");
                }
                denom = value;
            }
        }



        public RationalNumbers(int num, int denom)
        {
            Num = num;
            Denom = denom;
        }

        public RationalNumbers Plus(RationalNumbers other)
        {
            int num = Num * other.denom + Denom * other.num;
            int denom = Denom * other.denom;
            return new RationalNumbers(num, denom);
        }

        public RationalNumbers Minus(RationalNumbers other)
        {
            int num = Num * other.denom - Denom * other.num;
            int denom = Denom * other.denom;
            return new RationalNumbers(num, denom);
        }

        public RationalNumbers Mult(RationalNumbers other)
        {
            int num = Num * other.num;
            int denom = Denom * other.denom;
            return new RationalNumbers(num, denom);
        }

        public RationalNumbers Div(RationalNumbers other)
        {
            int num = Num * other.denom;
            int denom = Denom * other.num;
            return new RationalNumbers(num, denom);
        }



        public override string ToString()
        {
            int numOld = Num;
            int denOld = Denom;
            Nod();

            return $"{numOld}/{denOld}; упрощенная дробь: {Num}/{Denom}";            
        }


        /// <summary>
        /// Нормальизация дроби
        /// </summary>
        private void Nod()
        {
            // Пусть мы решили упростить дробь -4/6

            var nuM = Math.Abs(num); // Создаем вспомогательную переменную, модуль числителя (4)
            var den = Math.Abs(denom); // Создаем вспомогательную переменную, модуль знаменателя (6)
            int temp; // Вспомогательная переменная

            while (nuM != 0 && den != 0) // Цикл, до тех пор, пока обе вспомогательные переменные не равны нулю
            {
                if (nuM % den > 0) // Если остаток от деления числителя на знаменатель больше нуля ( т е остаток присутствует)
                {
                    // При первой итерации: 4 % 6 = 4

                    temp = nuM; // Вспомогательная переменная теперь хранит значение числителя (4)
                    nuM = den; // Переменная числителя сохраняет значение знаменателя
                    den = temp % den; // Знаменатель теперь хранит тот самый остаток от деления числителя на занаменатель 4 % 6 = 4, теперь тут лежит 4 (получается 6/4)
                }
                else
                    break;
                // При повторой итерации цикла, у нас выполняется выражение 6 % 4 = 2
                // Теперь в переменной temp хранится 6, в перменной num хранится 4, в переменной den = 6 % 4 = 2

                // Третья итерация цикла 4 % 2 = 0 и вот тут мы понимаем, что 4 делится на 2 без остатка, следовательно цикл while завершает свою работу, 
                // мы выходим через break;

            }


            // Что мы получаем? теперь мы берем начальные значения числителя и знаменателя и делим их на последнее значение переменной den (которое равно 2)
            if (nuM != 0 && den != 0)
            {
                num = num / den; // -4/2 = -2
                denom = denom / den; // 6/2 = 3
            }
            // Итого, у нас была дробь -4/6, стала -2/3, что и требовалось получить, мы сократили дробь на 2
        }
    }
        #endregion
}
