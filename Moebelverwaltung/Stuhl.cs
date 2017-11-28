using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    // eine Klasse kann eine andere Klasse erweitern
    // und beliebig viele Interfaces implementieren
    // Syntax: class Klasse : Basisklasse, IInterface1,...
    public class Stuhl : Moebelstueck, ISitzgelegenheit
    {

        public bool Polster { get; set; }

        public bool Armlehnen { get; set; }

        // wird kein eigener Konstruktor definiert,
        // wird ein Konstruktor ohne Parameter bereitgestellt,
        // der automatisch den Konstruktor ohne Parameter
        // seiner Basisklasse aufruft
        // Konstruktor ohne Parameter
        public Stuhl() 
            : this(150,100,180,10.0,"braun",Material.Holz,true,false)
        {
            Console.WriteLine("Stuhl()");
        }
        public Stuhl(int laenge, int breite, int hoehe,
                     double gewicht, string farbe, Material materialart,
                     bool gepolstert, bool armlehnen)
            // Weiterleitung an den Konstruktor der direkten Basisklasse
            // wird weder base noch this angegeben,
            // wird an den Konstruktor der Basisklasse weitergeleitet,
            // der keine Parameter hat
            : base(laenge, breite, hoehe, gewicht, farbe, materialart)
        {
            Console.WriteLine("Stuhl(alle Parameter)");
            Polster = gepolstert;
            Armlehnen = armlehnen;

        }

        // abstrakte Methode aus abstrakter Klasse überschrieben
        // -> override muss verwendet werden 
        public override double BerechnePreis()
        {
            return 100.0;
        }
        // abstrakte Methode aus Interface wird implementiert
        // -> override darf nicht verwendet werden
        public string Sitzen(string qualitaet)
        {
            string text = "";
            if (Polster)
                text += "Der Stuhl ist gepolstert.";
            else
                text += "Der Stuhl ist nicht gepolstert.";

            text += $" Auf dem Stuhl sitzt man {qualitaet}.";

            return text;
        }

        public override string ToString()
        {
            string text = $"Maße: {Laenge} cm x {Breite} cm x {Hoehe} cm.";
            text += " Farbe: " + Farbe + ";";
            text += " Materialart: " + Materialart + ";";
            if (Armlehnen) // if(Armlehnen == true)
                text += " Der Stuhl hat Armlehnen";
            else
                text += " Der Stuhl hat keine Armlehnen";

            if (!Polster) // if(Polster == false)
                text += " Der Stuhl ist nicht gepolstert";
            else
                text += " Der Stuhl ist gepolstert";

            return text;
        }
    }
}
