using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Christmas
{
    public class Toy: Decoration
    {
        public int Weight { get; set; }
        public bool IsFragile { get; set; }
        public Toy(int weight, bool fragile, int square, bool socket): base(square, socket)
        {
            Weight = weight;
            IsFragile = fragile;
        }
    }
}
