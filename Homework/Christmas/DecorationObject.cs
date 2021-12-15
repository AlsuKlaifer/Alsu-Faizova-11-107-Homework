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
    }
}
