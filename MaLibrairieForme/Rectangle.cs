using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public class Rectangle : Forme, ISommets
    {
        #region MEMBER VARIABLES
        private int _longueur;
        private int _largeur;
        #endregion

        #region CONSTRUCTORS
        public Rectangle(int x = 0, int y = 0, int longueur = 0, int largeur = 0)
        {
            _coord.X = x;
            _coord.Y = y;
            _longueur = longueur;
            _largeur = largeur;
        }

        public Rectangle(Coordonnee c, int longueur = 0, int largeur = 0)
        {
            _coord.X = c.X;
            _coord.Y = c.Y;
            _longueur = longueur;
            _largeur = largeur;
        }

        public Rectangle(Rectangle r)
        {
            _coord.X = r.Coord.X;
            _coord.Y = r.Coord.Y;
            _longueur = r.Longueur;
            _largeur = r.Largeur;
        }
        #endregion

        #region GETTERS/SETTERS
        public int Longueur
        {
            get { return _longueur; }
            set { _longueur = value; }
        }

        public int Largeur
        {
            get { return _largeur; }
            set { _largeur = value; }
        }
        #endregion

        #region METHODS
        public override string ToString()
        {
            return "{COORD " + _coord.ToString() + " - VALEURS (L = " + _longueur + " / l = " + _largeur + ")}";
        }

        public override void Affiche()
        {
            Console.WriteLine("Rectangle :\t" + ToString());
        }

        public override bool CoordonneeEstDans(Coordonnee p)
        {
            return _coord.X <= p.X && p.X <= _coord.X + _longueur && _coord.Y <= p.Y && p.Y <= _coord.Y + _largeur;
        }

        public byte NbSommet
        {
            get { return 4; }
        }
        #endregion
    }
}
