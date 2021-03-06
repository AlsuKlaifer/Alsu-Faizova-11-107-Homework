using System;

namespace Homework.Extension
{
    public class RationalFraction: IComparable
    {
        private int a;
        private int b;
        /// <summary>
        /// Числитель
        /// </summary>
        public int A { get { return a; } }
        /// <summary>
        /// Знаменатель
        /// </summary>
        public int B { get { return b; } }
        public RationalFraction()
        {
            a = 0;
            b = 1;
        }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="x">Числитель</param>
        /// <param name="y">Знаменатель</param>
        public RationalFraction(int x, int y)
        {
            a = x;
            b = y;
        }
        public void reduce_YourSelf()
        {
            int z = NOD(a, b);
            a = a / z;
            b = b / z;
        }
        public RationalFraction reduce(RationalFraction r)
        {
            int z = NOD(r.a, r.b);
            return new RationalFraction(r.a / z, r.b / z);
        }
        private int NOD(int x, int y)
        {
            x = Math.Abs(x);
            y = Math.Abs(y);
            while (x != 0 && y != 0)
            {
                if (x > y)
                    x = x % y;
                else
                    y = y % x;
            }
            return x + y;
        }
        private int NOK(int x, int y)
        {
            return x * y / NOD(x, y);
        }
        public RationalFraction Add(RationalFraction r)
        {
            int z = NOK(r.b, b);
            int z1 = z / b * a + z / r.b * r.a;
            RationalFraction newZ = new RationalFraction(z1, z);
            return reduce(newZ);
        }
        public void Add_ToYourself(RationalFraction r)
        {
            int z = NOK(r.b, b);
            a = z / b * a + z / r.b * r.a;
            b = z;
            reduce_YourSelf();
        }
        public RationalFraction Sub(RationalFraction r)
        {
            int z = NOK(r.b, b);
            int z1 = z / b * a - z / r.b * r.a;
            RationalFraction newZ = new RationalFraction(z1, z);
            return reduce(newZ);
        }
        public void Sub_ToYourself(RationalFraction r)
        {
            int z = NOK(r.b, b);
            a = z / b * a - z / r.b * r.a;
            b = z;
            reduce_YourSelf();
        }
        public RationalFraction Mult(RationalFraction r)
        {
            RationalFraction newZ = new RationalFraction(a * r.a, b * r.b);
            return reduce(newZ);
        }
        public int NumberPart()
        {
            return a / b;
        }
        public bool Equals(RationalFraction r)
        {
            r = reduce(r);
            var current = reduce(this);
            bool c = r.A == current.A && r.B == current.B;
            if (c == true)
                return true;
            else return false;
            
        }
        /// <summary>
        /// Десятичное значение дроби
        /// </summary>
        public double Value()
        {
            return (double) a / b;
        }
        public string RFToString()
        {
            return $"{a}/{b}";
        }
        /// <summary>
        /// Метод сравнения двух дробей
        /// </summary>
        // Возвращает	 0, если дроби равны
        //				 1, если this больше o
        //				-1, если this меньше o
        public int CompareTo(object o)
        {
            RationalFraction r = o as RationalFraction;
            if (r != null)
            {
                if (this.Equals(r))
                    return 0;
                if (this.A * r.B > r.A * this.B)
                    return 1;
                return -1;
            }
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}