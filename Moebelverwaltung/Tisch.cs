using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    /// <summary>
    /// Klasse, die einen Tisch näher beschreibt
    /// </summary>
    // Klasse Tisch erbt von Moebelstueck 
    // -> Klasse Tisch ist ein Moebelstueck
    // Klasse Tisch erweitert die Klasse Moebelstueck
    // alle Eigenschaften und Methoden von Moebelstueck geeerbt,
    // die nicht private oder static sind
    public class Tisch : Moebelstueck
    {
        // todo(1): Erstellung der Eigenschaften erledigt
        private int anzTischbeine;


        /// <summary>
        /// gibt die Anzahl der Tischbeine zurück
        /// </summary>
        public int AnzTischbeine
        {
            get { return anzTischbeine; }
            // Setzen der Tischbeine nur in derselben Klasse möglich
            private set
            {
                if (value > 0 && value <= 4)
                    anzTischbeine = value;
                else
                    anzTischbeine = 0;
            }
        }

        // Konstruktoren der Klasse Tisch
        public Tisch() : this(120,80,90,4, 5.0,"braun",Material.Holz)
        {
            Console.WriteLine("Tisch()");
        }
        public Tisch(int laenge, int breite, int hoehe, string farbe)
            : this(laenge:laenge,breite:breite,hoehe:hoehe,
              farbe:farbe,gewicht:7.0,materialart:Material.Holz,anzTischbeine:4)
        {
            Console.WriteLine("Tisch(4 Parameter)");
        }
        public Tisch(int laenge, int breite, int hoehe, int anzTischbeine, 
                     double gewicht, string farbe, Material materialart)
            // Weiterleitung an den Konstruktor der direkten Basisklasse
            // wird weder base noch this angegeben,
            // wird an den Konstruktor der Basisklasse weitergeleitet,
            // der keine Parameter hat
            : base(laenge, breite, hoehe, gewicht, farbe, materialart)
        {
            Console.WriteLine("Tisch(7 Parameter)");
            // Zuweisung der lokalen Variablen laenge an die Eigenschaft Laenge
            //Laenge = laenge;
            //Breite = breite;
            //Hoehe = hoehe;
            AnzTischbeine = anzTischbeine;
            //Gewicht = gewicht;
            //Farbe = farbe;
            //Materialart = materialart;
        }



        // Methode BerechnePreis() aus Moebelstueck wird überschrieben:
        // Überschreiben von Methoden findet immer in abgeleiteten Klassen statt
        // beim Überschreiben zu beachten:
        // - gleicher Methodenname
        // - Schlüsselwort override muss angegeben werden
        // - gleiche Parameterliste (ohne Parameter)
        // - gleicher Rückgabetyp
        // - der gleiche oder ein breiterer Zugriffsmodifizierer
        //   (internal -> protected -> public)
        public override double BerechnePreis()
        {
            return 0.0;
        }


        // Überladen von Methoden:
        // beim Überladen zu beachten:
        // - nur die Signatur der Methode (Name,Parameterliste) betrachtet
        // - Rückgabetyp und Zugriffsmodifierer nicht betrachtet
        // - gleicher Name
        // - eine unterschiedliche Parameterliste:
        //   - eine unterschiedliche Anzahl von Parametern 
        //   - unterschiedliche Datentypen der Parameter
        //   - eine unterschiedliche Reihenfolge der Parameter,
        //     wenn die Datentypen unterschiedlich sind

        /// <summary>
        /// schneidet die Tischoberfläche entsprechend zu
        /// ändert Länge und Breite des Tisch-Objekts, 
        /// für das die Methode Aendern() aufgerufen wird
        /// </summary>
        /// <param name="lang">neuer Wert für Länge und Breite</param>
        public void Aendern(int lang)
        {
            Console.WriteLine("Aendern(int)");
            Laenge = lang;
            Breite = lang;
        }

        public void Aendern(int lang, int breit)
        {
            Console.WriteLine("Aendern(int,int)");
            Laenge = lang;
            Breite = breit;
        }

        public void Aendern(string lang, string breit)
        {
            Console.WriteLine("Aendern(string,string)");
            //Nutzung der Klasse Convert, um Zeichenketten zu konvertieren
            // Klasse Convert hat statische Methoden zum Umwandeln
            // Aufruf einer statischen Methode: Klassenname.Methodenname()
            Laenge = Convert.ToInt32(lang);
            // Nutzung der Struktur Int32 (int)
            // -> statische Methode Parse() verwendet
            Breite = int.Parse(breit);
        }
        public void Aendern(int lang, string breit)
        {
            Console.WriteLine("Aendern(int,string)");
           
            int breite=0;
            if (int.TryParse(breit, out breite))
                Console.WriteLine("Konvertierung erfolgreich");
            else
                Console.WriteLine("Konvertierung fehlgeschlagen");

            Breite = breite;
            Laenge = lang;
        }
        public void Aendern(string breit, int lang)
        {
            Console.WriteLine("Aendern(string,int)");
            Laenge = lang;

            int breite = 0;
            // TryParse() gibt true bzw. false zurück
            // der Ausgabeparameter enthält Zahlenwert (0 im Fehlerfall)
            if (int.TryParse(breit, out breite))
            {
                Console.WriteLine("Konvertierung erfolgreich");
                Breite = breite;
            }
            else
                Console.WriteLine("Konvertierung fehlgeschlagen");
        }
        // ungültiges Überladen:
        // da sich die Methode Aendern(string,int) nur durch 
        // den Rückgabetyp (statt void wird bool verwendet) unterscheidet,
        // ist es eine ungültige Überladung -> Compilerfehler
        //public bool Aendern(string breit, int lang){}
        
        // mögliche Fehlerkorrekturen: Änderung des Namens oder der Parameterliste
        // wird Name geändert, ist es eine komplett neue Methode
        public bool Aendern2(string breit, int lang)
        {
            Console.WriteLine("Aendern2(string,int)");
            Laenge = lang;

            int breite = 0;
            // TryParse() gibt true bzw. false zurück
            // der Ausgabeparameter enthält Zahlenwert (0 im Fehlerfall)
            if (int.TryParse(breit, out breite))
            {
                Console.WriteLine("Konvertierung erfolgreich");
                Breite = breite;
                return true;
            }
            else
            {
                Console.WriteLine("Konvertierung fehlgeschlagen");
                return false;
            }
        }

        // eine nicht-abstrakte Methode aus Moebelstueck überschreiben:
        // public string Herstellen(string firma){}
        // Methode, die abgeleiteter Methode überschrieben werden soll,
        // muss in der Basisklasse mit virtual versehen werden
        // beim Überschreiben zu beachten:
        // - in Basisklasse Methode mit virtual versehen
        // - in abgeleiteter Klasse Methode mit override versehen
        // - gleicher Name
        // - gleicher Rückgabetyp
        // - gleiche Parameterliste (Anzahl und Datentypen müssen identisch sein)
        // - der gleiche oder ein breiterer Zugriffsmodifizierer 
        public override string Herstellen(string firma)
        {
            // mittels base.Methodenname 
            // Zugriff auf die gleichnamige Methode der Basisklasse
            string text = base.Herstellen(firma);
            // neuen Text an den String anhängen
            // text = text + "Der Firmensitz ist in Dresden";
            text += "Der Firmensitz ist in Dresden";
            return text;
        }

        // Methode ToString() aus Object überschreiben,
        // um das aktuelle Objekt als String zurückzugeben
        // String in allen grafischen Anwendungen benötigt
        public override string ToString()
        {
            string text = $"Maße: {Laenge} cm x {Breite} cm x {Hoehe} cm.";
            text += " Farbe: " +Farbe+";";
            text += " Materialart: " + Materialart+";";
            text += $" Der Tisch hat {AnzTischbeine} Bein(e)";
            return text;
        }
        /// <summary>
        /// kopiert ein Tisch - Objekt
        /// </summary>
        /// <returns>Tisch</returns>
        public Tisch Clone()
        {
            // MemberwiseClone() von Object erstellt eine flache Kopie
            // und gibt ein Objekt vom Typ object zurück 
            // -> muss in Kindklassen-Objekt umgewandelt werden
            // flache Kopie: Werttypen werden direkt kopiert,
            // bei den Referenztypen werden nur die Referenzvariablen,
            // nicht die Objekte, auf die diese verweisen
            Tisch t1 = (Tisch)MemberwiseClone();
            // Eigenschaften für Referenztypen festlegen
            t1.Farbe = Farbe;
            t1.Materialart = Materialart;
            return t1;
        }

        // Überschreiben der Methode Equals(), 
        // um Tischobjekte zu vergleichen
        public override bool Equals(object obj)
        {
            // gibt false zurück, falls übergebenes Objekt null ist
            // gibt false zurück, 
            // falls die Datentypen der Objekte unterschiedlich sind
            // GetType().ToString() gibt Klassennamen inkl. Namespace
            // als String zurück
            if (obj == null || GetType().ToString() != obj.GetType().ToString())
                return false;
            else
            {
                // eigentlicher Vergleich
                Tisch t = (Tisch)obj;
                // Farbe,AnzTischbeine,Gewicht nicht in Vergleich drin,
                // da diese für unsere Zwecke nicht gebraucht werden
                return Laenge == t.Laenge && Breite == t.Breite
                       && Hoehe == t.Hoehe && Materialart == t.Materialart; 
            }
        }

        #region Operatoren
        //Operator == zum Vergleichen von Tisch - Objekten überladen
        // wenn == überladen wird, sollte auch != überladen werden
        /// <summary>
        /// vergleicht zwei Tisch-Objekte miteinander;
        /// gibt true bei Gleichheit zurück
        /// </summary>
        /// <param name="t1">Tisch 1</param>
        /// <param name="t2">Tisch 2</param>
        /// <returns>gibt true bei Gleichheit zurück</returns>
        public static bool operator ==(Tisch t1, Tisch t2)
        {
            // prüft, ob alle Eigenschaften übereinstimmen
            return t1.Laenge == t2.Laenge && t1.Breite == t2.Breite
                   && t1.Hoehe == t2.Hoehe && t1.Materialart == t2.Materialart
                   && t1.Gewicht == t2.Gewicht && t1.Farbe == t2.Farbe
                   && t1.AnzTischbeine == t2.AnzTischbeine;

        }
        /// <summary>
        /// vergleicht zwei Tisch-Objekte miteinander; 
        /// gibt true bei Ungleichheit zurück
        /// </summary>
        /// <param name="t1">Tisch 1</param>
        /// <param name="t2">Tisch 2</param>
        /// <returns>gibt true bei Ungleichheit zurück</returns>
        public static bool operator !=(Tisch t1, Tisch t2)
        {
            // Verwendung des überladenen Operators ==
            return !(t1 == t2);
        }

        /// <summary>
        /// addiert Tische (Tische werden zusammengestellt)
        /// </summary>
        /// <param name="t1">Tisch 1</param>
        /// <param name="t2">Tisch 2</param>
        /// <returns>zusammengestellter Tisch aus Tisch 1 und Tisch 2</returns>
        public static Tisch operator+(Tisch t1, Tisch t2)
        {
            int neueLaenge = t1.Laenge + t2.Laenge;
            double neuesGewicht = t1.Gewicht + t2.Gewicht;
            return new Tisch(neueLaenge, t1.Breite, t1.Hoehe, t1.AnzTischbeine,
                             neuesGewicht, t1.Farbe, t1.Materialart);
        }
        /// <summary>
        /// subtrahiert zwei Tische (Tische wieder getrennt);
        /// Tisch 2 wird entfernt
        /// </summary>
        /// <param name="t1">zusammengestellter Tisch</param>
        /// <param name="t2">alter Tisch 2</param>
        /// <returns>alte Tisch 1 - Tisch 2 wird entfernt</returns>
        public static Tisch operator-(Tisch t1, Tisch t2)
        {
            int neueLaenge = t1.Laenge - t2.Laenge;
            double neuesGewicht = t1.Gewicht - t2.Gewicht;
            return new Tisch(neueLaenge, t1.Breite, t1.Hoehe, t1.AnzTischbeine,
                             neuesGewicht, t1.Farbe, t1.Materialart);
        }

        #endregion
    }
}
