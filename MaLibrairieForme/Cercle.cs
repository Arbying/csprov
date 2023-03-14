using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class Cercle : Forme
    {
        #region MEMBER VARIABLES
        private int _rayon;
        #endregion

        #region CONSTRUCTORS
        public Cercle(int x = 0, int y = 0, int r = 0)
        {
            _coord.X = x;
            _coord.Y = y;
            _rayon = r;
        }

        public Cercle(Coordonnee c, int r = 0)
        {
            _coord.X = c.X;
            _coord.Y = c.Y;
            _rayon = r;
        }

        public Cercle(Cercle c)
        {
            _coord.X = c.Coord.X;
            _coord.Y = c.Coord.Y;
            _rayon = c.Rayon;
        }
        #endregion

        #region GETTERS/SETTERS
        public int Rayon
        {
            get { return _rayon; }
            set { _rayon = value; }
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return "{COORD " + _coord.ToString() + " - VALEUR (r = " + _rayon + ")}";
        }

        public override void Affiche()
        {
            Console.WriteLine("Cercle :\t" + ToString());
        }

        public override bool CoordonneeEstDans(Coordonnee p)
        {
            return Math.Pow(p.X - _coord.X, 2) + Math.Pow(p.Y - _coord.Y, 2) <= Math.Pow(_rayon, 2);
        }
        #endregion
    }
}
