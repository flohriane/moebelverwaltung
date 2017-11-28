using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
   public class Schreibtisch : Tisch
    {
        public Schubfach Schubfach1 { get; set; }
        public bool Steckdosenleiste { get; set; }

        public Schreibtisch()
            :this(120,80,90,4,6.5,"hellbraun",Material.Holz,true,new Schubfach(120,60,20))
        {
            Console.WriteLine("Schreibtisch()");
        }

        public Schreibtisch(int laenge, int breite, int hoehe, int anzTischbeine,
                     double gewicht, string farbe, Material materialart,bool steckdosenleiste, Schubfach sf)
            // Weiterleitung an den Konstruktor von Tisch
            : base(laenge,breite,hoehe,anzTischbeine,gewicht,farbe,materialart)
        {
            Console.WriteLine("Schreibtisch(alle Parameter)");
            Steckdosenleiste = steckdosenleiste;
            Schubfach1 = sf;
        }

        public override string ToString()
        {
            string text = base.ToString();
            text += "Schubfach: " + Schubfach1.Laenge + " cm x ";
            text += Schubfach1.Breite + " cm x ";
            text += Schubfach1.Hoehe +" cm.";
            if (Steckdosenleiste)
                text += "Der Schreibtisch hat eine Steckdosenleiste.";
            else
                text += "Der Schreibtisch hat keine Steckdosenleiste.";
            return text;
        }

        public override double BerechnePreis()
        {
            const double MWST = 0.19;
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
                default:
                    break;
            }

            int flaeche = Laenge * Breite;
            if (flaeche <= 20000)
                preis += 200.0;
            else if (flaeche <= 50000)
                preis += 450.0;
            else
                preis += 600.0;

            preis *= 1 + MWST;

            return preis;
        }

        public void Reparieren(bool fehlerhaft)
        {
            if (fehlerhaft)
                Console.WriteLine("Der Tisch muss repariert werden");
            else
                Console.WriteLine("Es muss nichts repariert werden");
        }
        /// <summary>
        /// gibt eine Kopie des Schreibtisch - Objekts zurück
        /// </summary>
        /// <returns></returns>
        public new Schreibtisch Clone()
        {
            Schreibtisch st = (Schreibtisch)base.Clone();
            st.Schubfach1 = Schubfach1.Clone();
            return st;
        }

        public override bool Equals(object obj)
        {
            // um Schubfach1 in Vergleich mit aufzunehmen,
            // muss Equals() in Schubfach überschrieben werden
            Schreibtisch st = (Schreibtisch)obj;
            return base.Equals(st) 
                   && Steckdosenleiste == st.Steckdosenleiste
                   && Schubfach1.Equals(st.Schubfach1);
        }
    }
}
