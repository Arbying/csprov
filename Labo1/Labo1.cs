using MaLibrairieForme;
using Comparer;

/**************************************************
 *                   COORDONNEE                   *
 **************************************************/

Console.WriteLine("Coordonnee :");

Coordonnee coord1 = new();
Coordonnee coord2 = new(6, 3);
Coordonnee coord3 = new(coord2);

Console.WriteLine("coord1 - Constructeur par défaut :");
Console.WriteLine(coord1);
Console.WriteLine("coord2 - Constructeur d'initialisation (6, 3) :");
Console.WriteLine(coord2);
Console.WriteLine("coord3 - Constructeur de copie (coord2) :");
Console.WriteLine(coord3);

Console.WriteLine("--------------------------------------------------------------");

/**************************************************
 *                      CARRE                     *
 **************************************************/

Console.WriteLine("Carre :");

Carre carre1 = new();
Carre carre2 = new(2, 7, 12);
Carre carre3 = new(coord2, 5);
Carre carre4 = new(carre2);

Console.WriteLine("carre1 - Constructeur par défaut :");
carre1.Affiche();
Console.WriteLine("carre2 - Constructeur d'initialisation (2, 7, 12) :");
carre2.Affiche();
Console.WriteLine("carre3 - Constructeur d'initialisation (coord2, 5) :");
carre3.Affiche();
Console.WriteLine("carre4 - Constructeur de copie (carre2) :");
carre4.Affiche();

Console.WriteLine("--------------------------------------------------------------");

/**************************************************
 *                     CERCLE                     *
 **************************************************/

Console.WriteLine("Cercle :");

Cercle cercle1 = new();
Cercle cercle2 = new(6, 8, 3);
Cercle cercle3 = new(coord2, 1);
Cercle cercle4 = new(cercle2);

Console.WriteLine("cercle1 - Constructeur par défaut :");
cercle1.Affiche();
Console.WriteLine("cercle2 - Constructeur d'initialisation (6, 8, 3) :");
cercle2.Affiche();
Console.WriteLine("cercle3 - Constructeur d'initialisation (coord2, 1) :");
cercle3.Affiche();
Console.WriteLine("cercle4 - Constructeur de copie (cercle2) :");
cercle4.Affiche();

Console.WriteLine("--------------------------------------------------------------");

/**************************************************
 *                    RECTANGLE                   *
 **************************************************/

Console.WriteLine("Rectangle :");

Rectangle rectangle1 = new();
Rectangle rectangle2 = new(5, 8, 6, 3);
Rectangle rectangle3 = new(coord2, 9, 5);
Rectangle rectangle4 = new(rectangle2);

Console.WriteLine("rectangle1 - Constructeur par défaut :");
rectangle1.Affiche();
Console.WriteLine("rectangle2 - Constructeur d'initialisation (5, 8, 6, 3) :");
rectangle2.Affiche();
Console.WriteLine("rectangle3 - Constructeur d'initialisation (coord2, 9, 5) :");
rectangle3.Affiche();
Console.WriteLine("rectangle4 - Constructeur de copie (rectangle2) :");
rectangle4.Affiche();

Console.WriteLine("##############################################################");

/**************************************************
 *                      LISTE                     *
 **************************************************/

List<Forme> formes = new();

// CARRE
formes.Add(carre1);
formes.Add(carre2);
formes.Add(carre3);

// CERCLE
formes.Add(cercle1);
formes.Add(cercle2);
formes.Add(cercle3);

// RECTANGLE
formes.Add(rectangle1);
formes.Add(rectangle2);
formes.Add(rectangle3);

Console.WriteLine("Affichage des objets :");

foreach (Forme f in formes) {
    f.Affiche();
}

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Affichage des objets implémentant l’interface ISommets :");

foreach (Forme f in formes)
{
    if (f is ISommets)
    {
        f.Affiche();
    }
}

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Affichage des objets n'implémentant pas l’interface ISommets :");

foreach (Forme f in formes)
{
    if (f is not ISommets)
    {
        f.Affiche();
    }
}

Console.WriteLine("##############################################################");

List<Carre> carres = new();

carres.Add(new Carre { Coord = new Coordonnee { X = 3, Y = 9 }, Longueur = 4 });
carres.Add(new Carre { Coord = new Coordonnee { X = 6, Y = 2 }, Longueur = 2 });
carres.Add(new Carre { Coord = new Coordonnee { X = 1, Y = 8 }, Longueur = 7 });
carres.Add(new Carre { Coord = new Coordonnee { X = 5, Y = 5 }, Longueur = 3 });
carres.Add(new Carre { Coord = new Coordonnee { X = 2, Y = 3 }, Longueur = 5 });

Console.WriteLine("Liste générique de 5 carrés :");

foreach (Carre c in carres)
{
    c.Affiche();
}

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Liste triée par taille croissante :");

carres.Sort();

foreach (Carre c in carres)
{
    c.Affiche();
}

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Liste triée par abscisse croissante :");

FormeAbscisseComparer fcomp = new();
carres.Sort(fcomp);

foreach (Carre c in carres)
{
    c.Affiche();
}

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Carré de référence :");

Carre reference = new(5, 3, 4);
reference.Affiche();

Console.WriteLine("Carrés qui ont la même taille que le carré de référence :");

foreach (Carre c in carres.FindAll(x => x.Longueur == reference.Longueur))
{
    c.Affiche();
}

Console.WriteLine("##############################################################");
Console.WriteLine("Formes :");

List<Forme> formesp = new();

formesp.Add(new Carre { Coord = new Coordonnee { X = 5, Y = 2 }, Longueur = 6 });
formesp.Add(new Cercle { Coord = new Coordonnee { X = 7, Y = 9 }, Rayon = 4 });
formesp.Add(new Rectangle { Coord = new Coordonnee { X = 3, Y = 5 }, Longueur = 5, Largeur = 3 });

foreach (Forme f in formesp)
{
    f.Affiche();
}

Console.WriteLine("--------------------------------------------------------------");
Coordonnee coordp = new(9, 7);
Console.WriteLine("Formes qui contiennent le point " + coordp + " :");

foreach (Forme f in formesp.FindAll(x => x.CoordonneeEstDans(coordp)))
{
    f.Affiche();
}

Console.WriteLine("--------------------------------------------------------------");
Console.WriteLine("Liste triée par surface croissante :");

FormeSurfaceComparer scomp = new();
formesp.Sort(scomp);

foreach (Forme f in formesp)
{
    f.Affiche();
    Console.WriteLine("Surf : " + MathUtil.MathUtil.CalculerSurface(f));
}
