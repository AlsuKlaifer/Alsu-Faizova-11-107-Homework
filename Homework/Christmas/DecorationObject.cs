using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Christmas
{
    public abstract class DecorationObject
    {
        public string Name { get; }
        public int Square { get; set; }
        public int Sockets { get; set; }
        public DecorationObject(string name, int square, int sockets)
        {
            Name = name;
            Square = square;
            Sockets = sockets;
        }
        public void Decorating(Garland garland, Toy toy)
        {
            int x1 = 0;
            int x2 = 0;
            while (Square >= garland.Square && Sockets > 0)
            {
                Square = Square - garland.Square;
                Sockets--;
                x1++;
            }
            Console.WriteLine($"Объект {Name} украсили {x1} гирляндами. Оставшихся розеток: {Sockets} . Оставшаяся площадь: {Square}.");

            if (Square < garland.Square || Sockets == 0)
            {
                while (Square >= toy.Square)
                {
                    Square = Square - toy.Square;
                    x2++;
                }
                Console.WriteLine($"Объект {Name} украсили {x2} игрушками. Оставшаяся площадь: {Square}.");
            }
        }
    }
}
