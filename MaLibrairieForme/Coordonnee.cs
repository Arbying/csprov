using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class Coordonnee
    {
        #region MEMBER VARIABLES
        private int _x;
        private int _y;
        #endregion

        #region CONSTRUCTORS
        public Coordonnee(int x = 0, int y = 0)
        {
            _x = x;
            _y = y;
        }

        public Coordonnee(Coordonnee c)
        {
            _x = c.X;
            _y = c.Y;
        }
        #endregion

        #region GETTERS/SETTERS
        public int X {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return "(" + _x + "," + _y + ")";
        }
        #endregion
    }
}
