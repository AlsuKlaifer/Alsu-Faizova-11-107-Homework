using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Christmas
{
    public class Decorate
    { 

        public static void Decorating(DecorationObject x, Garland[] garland, Toy[] toy)
        {
            int x1 = 0;
            int x2 = 0;
            int i = 0;
            while (x.Square > 0 && x.Sockets > 0 && i < garland.Length && x.Square > garland[i].Square)
            {
                x.Square -= garland[i].Square;
                x.Sockets--;
                i++;
                x1++;
            }
            i = 0;
            while (x.Square > 0 &&  i < toy.Length && x.Square >= toy[i].Square)
            {
                x.Square -= toy[i].Square;
                i++;
                x2++;
            }
            Console.WriteLine($"Объект {x.Name} украсили {x1} гирляндами и {x2} игрушками. " +
                $"Оставшаяся площадь: {x.Square}. Оставшиеся розетки: {x.Sockets}");
        }
    }
}
