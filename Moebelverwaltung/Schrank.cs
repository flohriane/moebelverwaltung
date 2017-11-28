using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    /// <summary>
    /// Klasse, die einen Standardschrank näher beschreibt
    /// </summary>
    public class Schrank : Moebelstueck
    {
        // Datentyp uint: unsigned int: Ganzzahl ohne Vorzeichen
        public uint AnzEinlegeboeden { get; set; }


        // Konstruktoren
        // Konstruktor ohne Parameter
        public Schrank() 
            : this(150,100,180,10.0,"braun",Material.Holz,6)
        {
            Console.WriteLine("Schrank()");
        }

        public Schrank(int laenge,int breite, int hoehe)
            : this(laenge,breite,hoehe, 10.0, "braun", Material.Holz, 6)
        {
            Console.WriteLine("Schrank(int,int,int)");
        }

        // Konstruktor mit allen Parametern
        public Schrank(int laenge, int breite, int hoehe,double gewicht,
                       string farbe, Material materialart, uint anzBoeden)
            // Weiterleitung an den Konstruktor der direkten Basisklasse
            // wird weder base noch this angegeben,
            // wird an den Konstruktor der Basisklasse weitergeleitet,
            // der keine Parameter hat
            // this(): DIESE Klasse
            // base(): BASIS-Klasse
            : base(laenge,breite,hoehe,gewicht,farbe,materialart)
        {
            Console.WriteLine("Schrank(alle Parameter)");
            //Laenge = laenge;
            //Breite = breite;
            //Hoehe = hoehe;
            //Gewicht = gewicht;
            //Farbe = farbe;
            //Materialart = materialart;
            AnzEinlegeboeden = anzBoeden;
        }


        public override double BerechnePreis()
        {
           return 0.0;
        }
        /// <summary>
        /// gibt eine Kopie des Schrank - Objekts zurück
        /// </summary>
        /// <returns>Schrank</returns>
        public Schrank Clone()
        {
            Schrank s = (Schrank)MemberwiseClone();
            s.Materialart = Materialart;
            s.Farbe = Farbe;
            return s;
        }
        /// <summary>
        /// berechnet das Fassungsvermögen in Litern
        /// </summary>
        /// <returns>Fassungsvermögen in Liter</returns>
        public double GetVolumen()
        {
            // Laenge * Breite * Hoehe => cm³
            // 1 cm³ = 1 ml = 0.001 l
            return Laenge * Breite * Hoehe / 1000.0;
        }

        public static bool operator==(Schrank s1, Schrank s2)
        {
            return s1.Laenge == s2.Laenge && s1.Breite == s2.Breite
                   && s1.Hoehe == s2.Hoehe && s1.Materialart == s2.Materialart
                   && s1.Gewicht == s2.Gewicht && s1.Farbe == s2.Farbe
                   && s1.AnzEinlegeboeden == s2.AnzEinlegeboeden;
        }

        public static bool operator !=(Schrank s1, Schrank s2)
        {
            return !(s1 == s2);
        }
    }
}
