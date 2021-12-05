using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Christmas
{
    public class Garland : Decoration
    {
        public int NumberOfColor { get; set; }
        /// <summary>
        /// Количество режимов
        /// </summary>
        public int NumberOfModes { get; set; }
        public Garland(int colors, int modes, int square, bool socket) : base(square, socket)
        {
            NumberOfColor = colors;
            NumberOfModes = modes;
        }
    }
}
