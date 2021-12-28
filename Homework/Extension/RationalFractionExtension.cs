using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Extension
{
    public static class RationalFractionExtension
    {
        /// <summary>
        /// Является ли целым числом
        /// </summary>
        public static bool IsInteger(this RationalFraction rf)
        {
            rf.reduce_YourSelf();
            if (rf.A == rf.B)
                return true;
            return false;
        }
    }
}
