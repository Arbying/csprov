using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class Carre : Forme, ISommets, IComparable<Carre>
    {
        #region MEMBER VARIABLES
        private int _longueur;
        #endregion

        #region CONSTRUCTORS
        public Carre(int x = 0, int y = 0, int l = 0)
        {
            _coord.X = x;
            _coord.Y = y;
            _longueur = l;
        }

        public Carre(Coordonnee c, int l = 0)
        {
            _coord.X = c.X;
            _coord.Y = c.Y;
            _longueur = l;
        }

        public Carre(Carre c)
        {
            _coord.X = c.Coord.X;
            _coord.Y = c.Coord.Y;
            _longueur = c.Longueur;
        }
        #endregion

        #region GETTERS/SETTERS
        public int Longueur
        {
            get { return _longueur; }
            set { _longueur = value; }
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return "{COORD " + _coord.ToString() + " - VALEUR (c = " + _longueur + ")}";
        }

        public override void Affiche()
        {
            Console.WriteLine("Carré :\t\t" + ToString());
        }

        public override bool CoordonneeEstDans(Coordonnee p)
        {
            return _coord.X <= p.X && p.X <= _coord.X + _longueur && _coord.Y <= p.Y && p.Y <= _coord.Y + _longueur;
        }

        public byte NbSommet
        {
            get { return 4; }
        }

        public int CompareTo(Carre other)
        {
            return Longueur.CompareTo(other.Longueur);
        }
        #endregion
    }
}
