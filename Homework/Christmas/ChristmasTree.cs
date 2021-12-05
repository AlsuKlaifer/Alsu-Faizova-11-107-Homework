using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Christmas
{
    public class ChristmasTree : DecorationObject
    {
        public int Height { get; set; }
        public ChristmasTree(string name, int height, int square, int sockets) : base(name, square, sockets)
        {
            Height = height;
        }
    }
}
