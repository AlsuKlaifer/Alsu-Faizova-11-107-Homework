using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Christmas
{
    public abstract class Decoration
    {
        public int Square { get; set; }
        public bool Socket { get; set; }

        public Decoration(int square, bool socket)
        {
            Square = square;
            Socket = socket;
        }
    }
}
