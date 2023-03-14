using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaLibrairieForme;

namespace Comparer
{
    public class FormeSurfaceComparer : IComparer<Forme>
    {
        public int Compare(Forme x, Forme y)
        {
            return MathUtil.MathUtil.CalculerSurface(x).CompareTo(MathUtil.MathUtil.CalculerSurface(y));
        }
    }
}
