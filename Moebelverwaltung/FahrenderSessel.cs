using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    public class FahrenderSessel
         : Moebelstueck, IFahrendeSitzgelegenheiten
    {
        public FahrenderSessel()
            : this(100,80,70,12.0,"hellbraun",Material.Kunststoff,true,10.567)
        {
            Console.WriteLine("FahrenderSessel()");
        }
        public FahrenderSessel(int laenge, int breite, int hoehe, 
            double gewicht, string farbe, Material materialart,
            bool gepolstert, double v) 
            : base(laenge, breite, hoehe, gewicht, farbe, 
                    materialart)
        {
            Console.WriteLine("FahrenderSessel(alle Parameter)");
            Polster = gepolstert;
            Geschwindigkeit = v;
        }

        public double Geschwindigkeit { get; set; }

        public bool Polster { get; set; }


        public override double BerechnePreis()
        {
            return 100.0;
        }

        public string Fahren()
        {
            return $"Der Sessel kann {Geschwindigkeit:F1} km/h fahren";
        }

        public string Sitzen(string qualitaet)
        {
            string text = "";
            if (Polster)
                text += "Der Sessel ist extra gepolstert.";
            else
                text += "Der Sessel ist nicht gepolstert.";

            text += $" Auf dem Sessel sitzt man {qualitaet}.";

            return text;
        }
    }
}
