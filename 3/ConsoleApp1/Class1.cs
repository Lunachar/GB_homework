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
        public int num; // числитель
        public int denom; // знаменатель

        public int Num
        {
            get { return num; }
            set { num = value; }
        }
        public int Denom
        {
            get { return denom; }
            set { if(value == 0)
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
            return $"{Num}/{Denom}";
        }
    }
    #endregion
}
