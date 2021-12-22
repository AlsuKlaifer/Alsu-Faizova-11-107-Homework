namespace Homework.Extension
{
    public class ComplexNumber: ICloneable
    {
        private double a;
        private double b;
        public ComplexNumber()
        {
            a = 0;
            b = 0;
        }
        public ComplexNumber(double x, double y)
        {
            a = x;
            b = y;
        }
        public ComplexNumber Add(ComplexNumber r)
        {
            double z1 = a + r.a;
            double z2 = b + r.b;
            ComplexNumber z = new ComplexNumber(z1, z2);
            return z;
        }
        public void AddToYourself(ComplexNumber r)
        {
            a = a + r.a;
            b = b + r.b;
        }
        public ComplexNumber Sub(ComplexNumber r)
        {
            double z1 = a - r.a;
            double z2 = b - r.b;
            ComplexNumber z = new ComplexNumber(z1, z2);
            return z;
        }
        public void SubToYourself(ComplexNumber r)
        {
            a = a - r.a;
            b = b - r.b;
        }
        /// <summary>
        /// Произведение комплексного числа на вещественное
        /// </summary>
        public ComplexNumber Mult(double n)
        {
            double z1 = a * n;
            double z2 = b * n;
            ComplexNumber z = new ComplexNumber(z1, z2);
            return z;
        }
        public void MultToYourself(double n)
        {
            a = a * n;
            b = b * n;
        }
        /// <summary>
        /// Произведение двух комплексных чисел
        /// </summary>
        public ComplexNumber Multiplication(ComplexNumber r)
        {
            double z1 = a * r.a - (b * r.b);
            double z2 = a * r.b + b * r.a;
            ComplexNumber z = new ComplexNumber(z1, z2);
            return z;
        }
        public void MultiplicationToYourself(ComplexNumber r)
        {
            a = a * r.a - (b * r.b);
            b = a * r.b + b * r.a;
        }
        /// <summary>
        /// Деление комплексного числа на комплексное число
        /// </summary>
        public ComplexNumber Div(ComplexNumber r)
        {
            var rb1 = r.b * (-1);
            var d = r.a * r.a + r.b * r.b;
            double z1 = (a * r.a - (b * rb1)) / d;
            double z2 = (a * rb1 + b * r.a) / d;
            ComplexNumber z = new ComplexNumber(z1, z2);
            return z;
        }
        public void DivToYourself(ComplexNumber r)
        {
            a = (a * r.a - (b * r.b * (-1))) / (r.a * r.a + r.b * r.b);
            b = (a * r.b * (-1) + b * r.a) / r.a * r.a + r.b * r.b;
        }
        /// <summary>
        /// Модуль комплексного числа
        /// </summary>
        public double Length()
        {
            return Math.Sqrt(a * a + b * b);
        }
        public double Arg()
        {
            double z;
            if (a > 0)
                z = Math.Atan(b / a);
            else if (a < 0 && b >= 0)
                z = Math.PI + Math.Atan(b / a);
            else if (a < 0 && b < 0)
                z = -Math.PI + Math.Atan(b / a);
            else if (a == 0 && b > 0)
                z = Math.PI / 2;
            else
                z = -Math.PI / 2;
            return z;
        }
        public ComplexNumber Pow(double n)
        {
            double z1 = Math.Pow(Length(), n) * Math.Cos(Arg() * n);
            double z2 = Math.Pow(Length(), n) * Math.Sin(Arg() * n);
            ComplexNumber z = new ComplexNumber(z1, z2);
            return z;
        }
        /// <summary>
        /// Вывод комплексного числа
        /// </summary>
        public string Print()
        {
            string z;
            if (b < 0)
                z = $"{a} - {-b}i";
            else if (b == 0)
                z = $"{a}";
            else if (a == 0)
                z = $"{b}i";
            else
                z = $"{a} + {b}i";
            return z;
        }

        public object Clone()
        {
            return new ComplexNumber { a = this.a, b = this.b };
        }
    }
}
