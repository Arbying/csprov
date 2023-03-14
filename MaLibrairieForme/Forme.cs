using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaLibrairieForme
{
    public abstract class Forme : IEstDans
    {
        #region MEMBER VARIABLES
        protected Coordonnee _coord;
        #endregion

        #region CONSTRUCTORS
        public Forme()
        {
            _coord = new Coordonnee();
        }
        #endregion

        #region GETTERS/SETTERS
        public Coordonnee Coord
        {
            get { return _coord; }
            set { _coord = value; }
        }
        #endregion

        #region METHODS
        public abstract void Affiche();
        public abstract bool CoordonneeEstDans(Coordonnee p);
        #endregion
    }
}
