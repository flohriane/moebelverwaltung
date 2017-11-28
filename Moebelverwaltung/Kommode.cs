using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    /// <summary>
    /// Kommode, die eine Art kleinerer Schrank ist
    /// </summary>
    public class Kommode : Schrank
    {
        // Klasse Kommode hat mehrere Schubfach - Objekte
        // zwischen Klassen Kommode und Schubfach besteht
        // eine hat-eine - Beziehung (has-a relationship)
        public Schubfach Schubfach1 { get; set; }
        public Schubfach Schubfach2 { get; set; }
        public Schubfach Schubfach3 { get; set; }
        public Schubfach Schubfach4 { get; set; }

        // Konstruktoren
        public Kommode() 
            : this(120, 60, 90, 3.0, "braun",
               Material.Holz,4,new Schubfach(),new Schubfach(), new Schubfach(),new Schubfach())
        {
            Console.WriteLine("Kommode()");
        }
        /// <summary>
        /// Konstruktor, der alle Werte für eine Kommode setzt
        /// </summary>
        /// <param name="laenge"></param>
        /// <param name="breite"></param>
        /// <param name="hoehe"></param>
        /// <param name="gewicht"></param>
        /// <param name="farbe"></param>
        /// <param name="materialart"></param>
        /// <param name="anzEinlegeboeden"></param>
        /// <param name="sf1">Schubfach links oben</param>
        /// <param name="sf2"></param>
        /// <param name="sf3"></param>
        /// <param name="sf4"></param>
        public Kommode(int laenge, int breite, int hoehe,
                     double gewicht, string farbe, Material materialart,
                     uint anzEinlegeboeden,Schubfach sf1, Schubfach sf2,Schubfach sf3,Schubfach sf4)
            // Weiterleitung an Konstruktor von Schrank
            : base(laenge, breite, hoehe, gewicht, farbe, materialart,anzEinlegeboeden)
        {
            Console.WriteLine("Kommode(alle Parameter)");
            Schubfach1 = sf1;
            Schubfach2 = sf2;
            Schubfach3 = sf3;
            Schubfach4 = sf4;
        }

        // Überschreiben der Methode BerechnePreis() aus Schrank
        /// <summary>
        /// berechnet den Preis der Kommode abhängig vom Material
        /// Preis in Euro inkl. 19% Mehrwertsteuer
        /// </summary>
        /// <returns>double</returns>
        public override double BerechnePreis()
        {
            double preis = 0.0;
            switch (Materialart)
            {
                case Material.Holz:
                    preis = 100.0;
                    break;
                case Material.Stahl:
                    preis = 200.0;
                    break;
                case Material.Glas:
                    preis = 150.0;
                    break;
                case Material.Kunststoff:
                    preis = 75.0;
                    break;
                // nicht ausgeführt, da alle Konstanten angegeben wurden 
                default:
                    break;       
            }
            //preis = preis * 1.19;
            preis *= 1.19;
            return preis;
        }
        // überschriebene Methode Herstellen() aus Moebelstueck
        public override string Herstellen(string firma)
        {
            // Aufruf der geerbten Methode von Schrank
            string text = base.Herstellen(firma);
            text += "Die Firma sitzt in Hamburg.";
            return text;
        }

        // überladene Methode Herstellen()
        public string Herstellen(string firma,string ansprechpartner)
        {
            // Verwendung der überschriebenen Methode Herstellen()
            return Herstellen(firma) + " Der Ansprechpartner ist " 
                   + ansprechpartner + ".";
        }
        /// <summary>
        /// erzeugt eine Kopie eines Kommode - Objekts
        /// </summary>
        /// <returns></returns>
        public Kommode Clone()
        {
            // Aufruf der Methode Clone() der Basisklasse
            Kommode k = (Kommode)base.Clone();
            // Aufruf von Clone() notwendig, um Objekt zu kopieren
            // Clone() bereits in Schubfach-Klasse erstellt
            k.Schubfach1 = Schubfach1.Clone();
            k.Schubfach2 = Schubfach2.Clone();
            k.Schubfach3 = Schubfach3.Clone();
            k.Schubfach4 = Schubfach4.Clone();
            return k;
        }
    }
}
