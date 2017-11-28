using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Erstellung einer Variablen vom Typ der Klasse Schubfach
            //// sf1 ist eine Referenzvariable, 
            //// die später auf ein Schubfach - Objekt verweisen soll
            //Schubfach sf1;
            //// Erzeugung eines Objekts (Instanz) der Klasse Schubfach
            //// Aufruf des Konstruktors ohne Parameter
            //sf1 = new Schubfach();
            //// Nutzung des Konstruktors mit optionalen Parametern
            //// Verwendung von benannten Parametern
            //Schubfach sf2 = new Schubfach(laenge: 40, hoehe: 15, breite: 50);
            //Schubfach sf3 = new Schubfach(40,50,15,farbe:"schwarz");

            //Console.WriteLine("Schubfach sf1:");
            //// Aufruf der get-Methoden der jeweiligen Eigenschaften
            //// für die Instanz (das Objekt) sf1
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //                  sf1.Laenge,sf1.Breite,sf1.Hoehe);
            //// Gewicht mit 3 Nachkommastellen ausgegeben
            //// Formatierungsangaben auch in der Methode Format() von string verwendet
            //Console.WriteLine("Gewicht: {0:F3} kg",sf1.Gewicht);
            //Console.WriteLine("Farbe: "+sf1.Farbe);

            //Console.WriteLine("Schubfach sf2:");
            //// Aufruf der get-Methoden der jeweiligen Eigenschaften
            //// für die Instanz (das Objekt) sf1
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //                  sf2.Laenge, sf2.Breite, sf2.Hoehe);
            //// Gewicht mit 3 Nachkommastellen ausgegeben
            //// Formatierungsangaben auch in der Methode Format() von string verwendet
            //Console.WriteLine("Gewicht: {0:F3} kg", sf2.Gewicht);
            //Console.WriteLine("Farbe: " + sf2.Farbe);

            //Console.WriteLine("Schubfach sf3:");
            //// Aufruf der get-Methoden der jeweiligen Eigenschaften
            //// für die Instanz (das Objekt) sf1
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //                  sf3.Laenge, sf3.Breite, sf3.Hoehe);
            //// Gewicht mit 3 Nachkommastellen ausgegeben
            ////Formatierungsangaben auch in der Methode Format() von string verwendet
            //Console.WriteLine("Gewicht: {0:F3} kg", sf3.Gewicht);
            //Console.WriteLine("Farbe: " + sf3.Farbe);
            //Console.WriteLine("Volumen: {0:F3} cm³",sf3.BerechneVolumen());

            //Schubfach sf4 = sf3.Clone();

            //Console.WriteLine("Schubfach sf3:");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //                  sf3.Laenge, sf3.Breite, sf3.Hoehe);
            //Console.WriteLine("Schubfach sf4:");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //                  sf4.Laenge, sf4.Breite, sf4.Hoehe);

            //sf4.Laenge = 80;
            //Console.WriteLine("Schubfach sf3:");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //                  sf3.Laenge, sf3.Breite, sf3.Hoehe);
            //Console.WriteLine("Schubfach sf4:");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //                  sf4.Laenge, sf4.Breite, sf4.Hoehe);

            //Tisch t1 = new Tisch();
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //                  t1.Laenge, t1.Breite, t1.Hoehe);
            //Console.WriteLine("Farbe: " + t1.Farbe);
            //Console.WriteLine("Materialart: "+t1.Materialart);

            //Tisch t2 = new Tisch(150, 80, 90, "rot");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //                  t2.Laenge, t2.Breite, t2.Hoehe);
            //Console.WriteLine("Farbe: " + t2.Farbe);
            //Console.WriteLine("Materialart: " + t2.Materialart);

            // Nutzung des Konstruktors ohne Parameter
            //Schrank s1 = new Schrank();
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //                  s1.Laenge, s1.Breite, s1.Hoehe);
            //Console.WriteLine("Farbe: " + s1.Farbe);
            //Console.WriteLine("Materialart: "+s1.Materialart);
            //Console.WriteLine("Anzahl Einlegeböden: "+s1.AnzEinlegeboeden);

            //Schrank s2 = new Schrank(220,100,180);
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //      s2.Laenge, s2.Breite, s2.Hoehe);
            //Console.WriteLine("Farbe: " + s2.Farbe);
            //Console.WriteLine("Materialart: " + s2.Materialart);
            //Console.WriteLine("Anzahl Einlegeböden: " + s2.AnzEinlegeboeden);

            //Schrank s3 = new Schrank(250, 100, 200, 12.0, "beige", Material.Kunststoff, 10);
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //            s3.Laenge, s3.Breite, s3.Hoehe);
            //Console.WriteLine("Farbe: " + s3.Farbe);
            //Console.WriteLine("Materialart: " + s3.Materialart);
            //Console.WriteLine("Anzahl Einlegeböden: " + s3.AnzEinlegeboeden);

            //Tisch neuerTisch = new Tisch();
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //  neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);
            //// Aufruf der Methode Aendern(int)
            //neuerTisch.Aendern(80);
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //  neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);
            //// Aufruf der überladenen Methode Aendern() mit 2 int-Parametern
            //neuerTisch.Aendern(100, 90);
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //  neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);
            //// Aufruf der überladenen Methode Aendern() mit 2 Strings
            //neuerTisch.Aendern("120", "100");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //  neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);
            //// Aufruf der Methode Aendern(int,string)
            //neuerTisch.Aendern(110, "95");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //  neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);
            //// Aufruf der Methode Aendern(int,string)
            //neuerTisch.Aendern(110, "95a");
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //  neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);
            //// Aufruf der Methode Aendern(string,int)
            //neuerTisch.Aendern("80",100);
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //    neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);
            //// Aufruf der Methode Aendern(string,int)
            //neuerTisch.Aendern("75a", 110);
            //Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //    neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);
            //// Aufruf der Methode Aendern2(string,int)
            //bool ergebnis = neuerTisch.Aendern2("150", 120);
            //if(ergebnis)
            //{
            //    Console.WriteLine("Neuer Tisch erfolgreich gebaut:");
            //    Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //    neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);
            //}
            //else
            //{
            //    Console.WriteLine("Breite nicht geändert");
            //    Console.WriteLine("Maße: {0} cm x {1} cm x {2} cm",
            //    neuerTisch.Laenge, neuerTisch.Breite, neuerTisch.Hoehe);
            //}

            //// Aufruf der überschriebenen Methode Herstellen von Tisch
            //Console.WriteLine(neuerTisch.Herstellen("Ikea"));
            //// Aufruf der geerbten Methode Herstellen von Schrank
            //Schrank schrank = new Schrank();
            //Console.WriteLine(schrank.Herstellen("Ikea"));

            //Kommode kom = new Kommode();
            //Console.WriteLine("Preis: {0:F2} EUR", kom.BerechnePreis());
            //Console.WriteLine(kom.Herstellen("Ikea"));
            //Console.WriteLine(kom.Herstellen("Ikea", "Fr. Dr. Astrid Müller"));

            //Schubfach schubfach1 = new Schubfach(30,40,10,1,"grün");
            //Kommode kom2 = new Kommode(120, 40, 100, 3.0, "weiß", Material.Holz, 3, schubfach1, schubfach1, schubfach1, schubfach1);
            //Console.WriteLine("alle Schubfächer haben folgende Maße:");
            //Console.WriteLine("Schubfach: {0} cm x {1} cm x {2} cm",
            //    kom2.Schubfach1.Laenge,kom2.Schubfach1.Breite,kom2.Schubfach1.Hoehe);

            //Tisch tt1 = new Tisch();
            //Console.WriteLine(tt1);

            //Schreibtisch st1 = new Schreibtisch();
            //// Verwendung der überschriebenen ToString() - Methode
            //Console.WriteLine(st1);
            //Console.WriteLine($"Preis: {st1.BerechnePreis():F2} EUR");

            //Stuhl stuhl = new Stuhl();
            //Console.WriteLine(stuhl);
            //Console.WriteLine(stuhl.Sitzen("sehr gut"));

            //// Aufruf des Standardkonstruktors von Rollstuhl
            //Rollstuhl rollstuhl = new Rollstuhl();
            //// Anwendung der geeerbten ToString() - Methode
            //Console.WriteLine(rollstuhl);
            //// Aufruf der implementierten Methode Fahren() 
            //// aus dem Interface 
            //rollstuhl.Fahren();

            //FahrenderSessel sessel = new FahrenderSessel();
            //Console.WriteLine(sessel.Fahren());
            //Console.WriteLine(sessel.Sitzen("sehr gut"));

            //Tisch tisch1 = new Tisch();
            //Tisch tisch2 = new Tisch(180, 70, 90, 4, 5.0, "dunkelbraun", Material.Holz);
            //Schreibtisch schreibtisch1 = new Schreibtisch();
            //Schreibtisch schreibtisch2 = new Schreibtisch(180, 70, 90, 4, 5.0, 
            //    "dunkelbraun", Material.Holz, true, new Schubfach());

            //// Speichern der Tische in einer Liste
            //// Liste vom Typ List<Tisch> kann Tisch-Objekte
            //// und davon abgeleitete Objekte speichern
            //// Konstruktor kann als Parameter auch 
            //// eine Anfangskapazität übergeben werden
            //List<Tisch> listeTische = new List<Tisch>(/*5*/);
            //listeTische.Add(tisch1);
            //listeTische.Add(tisch2);
            //listeTische.Add(schreibtisch1);
            //listeTische.Add(schreibtisch2);

            //Console.WriteLine("Anzahl Elemente: "+listeTische.Count);
            //Console.WriteLine("Kapazität: "+listeTische.Capacity);
            //// Hinzufügen eines neuen Tisches
            //listeTische.Add(new Tisch(100, 100, 80, "weiß"));
            //Console.WriteLine("Anzahl Elemente neu: " + listeTische.Count);
            //Console.WriteLine("Kapazität neu: " + listeTische.Capacity);
            //listeTische.Add(new Couchtisch());
            //Console.WriteLine("Anzahl Elemente neu: " + listeTische.Count);
            //Console.WriteLine("Kapazität neu: " + listeTische.Capacity);
            //// Durchlaufen der Liste vom Typ List<Tisch>
            //// Verwendung des automatischen Typrückschlusses
            //foreach (var tisch in listeTische)
            //{
            //    // Nutzung der überschriebenen ToString() - Methode
            //    Console.WriteLine("{0}", tisch);
            //    // Anzeige, ob es sich um einen Tisch oder einen Schreibtisch handelt
            //    // mittels is geprüft, ob Objekt von einer bestimmten Klasse ist
            //    if (tisch is Schreibtisch)
            //    {
            //        Console.WriteLine("Art: ein Schreibtisch");
            //        // mittels as Umwandlung des Tisch-Objekts 
            //        // in ein Schreibtisch - Objekt 
            //        (tisch as Schreibtisch).Reparieren(true);

            //    }
            //    else if (tisch is Couchtisch)
            //    {
            //       Console.WriteLine("eine andere Tisch-Art"); 
            //    }
            //    // Tisch
            //    else
            //    {
            //        Console.WriteLine("Art: ein normaler Tisch");  
            //    }
            //}

            // prüfen, ob tisch1 ein Moebelstueck ist
            // is prüft, ob tisch1 ein Moebelstueck ist 
            // oder davon abgeleitet ist
            // oder ein bestimmtes Interface implementiert
            //if (tisch1 is Moebelstueck)
            //    Console.WriteLine("Der Tisch ist ein Möbelstück");
            //else
            //    Console.WriteLine("Der Tisch ist kein Möbelstück");

            //Schubfach schubfach1 = new Schubfach();
            //// prüfen, ob schubfach1 vom Typ Moebelstueck ist
            //if (schubfach1 is Moebelstueck)
            //    Console.WriteLine("Ein Schubfach ist ein Möblestück");
            //else
            //    Console.WriteLine("Ein Schubfach ist kein Möbelstück");

            //// Prüfen, ob ein bestimmtes Element in der Liste ist
            //if(listeTische.Contains(tisch2))
            //{
            //    Console.WriteLine("tisch2 ist in Liste.");
            //    string eingabe;
            //    Console.Write("Willst du den Tisch entfernen?: ");
            //    eingabe = Console.ReadLine();
            //    // eingabe.ToLower() wandelt eingegebene Buchstaben 
            //    // in Kleinbuchstaben um
            //    // prüfen, ob "ja" bzw. "j" eingegeben wurde
            //    if(eingabe.ToLower()=="ja" || eingabe.ToLower() == "j")
            //    {
            //        // Tisch mittels Remove entfernen
            //        // erstes Vorkommen von tisch2 wird entfernt
            //        // RemoveAll() löscht alle Vorkommen des übergebenen Elements
            //        listeTische.Remove(tisch2);   
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Objekt ist nicht vorhanden");
            //}
            //Console.WriteLine("Anzahl Elemente: " + listeTische.Count);



            //// neue Liste mit einer vorhandenen Liste initialisiert
            //List<Tisch> tische2016 = new List<Tisch>(listeTische);

            //List<Tisch> tische2017 = new List<Tisch>();
            //tische2017.Add(new Tisch(150,90,90,"rot"));
            //tische2017.Add(new Tisch(180, 90, 90, "blau"));
            //tische2017.Add(new Schreibtisch());
            //tische2017.Add(new Couchtisch());

            //// beide Listen in einem Dictionary speichern
            //// Dictionary speichert Schlüssel-Wert - Paare
            //// Schlüssel darf nur einmal vorkommen
            //// Dictionary<Key,Value>
            //Dictionary<string, List<Tisch>> aktuelleTische;
            //aktuelleTische = new Dictionary<string, List<Tisch>>();
            //// Syntax: dict.Add(Schlüssel(string), Wert(List<Tisch>);
            //aktuelleTische.Add("2016", tische2016);
            //aktuelleTische.Add("2017", tische2017);

            //// paar ist vom Typ KeyValuePair<string,List<Tisch>>
            //foreach (var paar in aktuelleTische)
            //{
            //    // Zugriff auf den Wert des Schlüssels des Dictionary
            //    string jahr = paar.Key;
            //    Console.WriteLine("Tische des Jahres "+jahr+":");
            //    List<Tisch> meineTische = paar.Value;
            //    foreach (var tisch in meineTische)
            //    {
            //        Console.WriteLine(tisch.ToString()); 
            //    }

            //}

            // Aufruf der statischen Methode ErstellenListe()
            // Syntax: Klassenname.Methodenname(Parameterliste)
            //Hilfsmethoden.ErstellenListe(20);

            //Tisch meinTisch1 = new Tisch(150, 80, 90, "weiß");
            //Tisch meinTisch2 = new Tisch(160, 80, 90, "braun");

            //Console.WriteLine("Tisch: {0} cm x {1} cm x {2} cm,Farbe: {3}",
            //                 meinTisch1.Laenge, meinTisch1.Breite, 
            //                 meinTisch1.Hoehe, meinTisch1.Farbe);
            //Console.WriteLine("Tisch: {0} cm x {1} cm x {2} cm,Farbe: {3}",
            //                 meinTisch2.Laenge, meinTisch2.Breite, 
            //                 meinTisch2.Hoehe, meinTisch2.Farbe);
            //// nach Zuweisung zeigen beide Referenzvariablen auf dasselbe Objekt
            //// altes Objekt, auf das meinTisch1 verwiesen hat, 
            //// ist nicht mehr referenzierbar 
            //// -> Objekt kann vom GarbageCollector eingesammelt werden
            //meinTisch1 = meinTisch2;
            //Console.WriteLine("Tisch: {0} cm x {1} cm x {2} cm,Farbe: {3}",
            //     meinTisch1.Laenge, meinTisch1.Breite,
            //     meinTisch1.Hoehe, meinTisch1.Farbe);
            //Console.WriteLine("Tisch: {0} cm x {1} cm x {2} cm,Farbe: {3}",
            //                 meinTisch2.Laenge, meinTisch2.Breite,
            //                 meinTisch2.Hoehe, meinTisch2.Farbe);
            //// Änderung der Länge des Tisches, 
            ////auf den beide Referenzvariablen zeigen 
            //meinTisch1.Laenge = 200;
            //Console.WriteLine("Tisch: {0} cm x {1} cm x {2} cm,Farbe: {3}",
            //     meinTisch1.Laenge, meinTisch1.Breite,
            //     meinTisch1.Hoehe, meinTisch1.Farbe);
            //Console.WriteLine("Tisch: {0} cm x {1} cm x {2} cm,Farbe: {3}",
            //                 meinTisch2.Laenge, meinTisch2.Breite,
            //                 meinTisch2.Hoehe, meinTisch2.Farbe);

            //// Zuweisen der Kopie von meinTisch2 an meinTisch3
            //Tisch meinTisch3 = meinTisch2.Clone();
            //Console.Write("meinTisch3: ");
            //Console.WriteLine(meinTisch3.ToString());
            //Console.Write("meinTisch2: ");
            //Console.WriteLine(meinTisch2.ToString());

            //// Änderung des neuen Tisches (meinTisch3)
            //meinTisch3.Farbe = "rot";
            //Console.Write("meinTisch3: ");
            //Console.WriteLine(meinTisch3.ToString());
            //// Farbe von meinTisch2 bleibt unverändert
            //Console.Write("meinTisch2: ");
            //Console.WriteLine(meinTisch2.ToString());

            Schrank meinSchrank1 = new Schrank();
            Schrank meinSchrank2 = meinSchrank1.Clone();

            Console.Write("meinSchrank1: ");
            Console.WriteLine("Länge: {0} cm, Breite: {0} cm",
                meinSchrank1.Laenge,meinSchrank1.Breite);
            Console.Write("meinSchrank2: ");
            Console.WriteLine("Länge: {0} cm, Breite: {0} cm",
                meinSchrank2.Laenge, meinSchrank2.Breite);
            // der Kopie eine neue Länge zuweisen
            meinSchrank2.Laenge = 350;
            Console.Write("meinSchrank1: ");
            Console.WriteLine("Länge: {0} cm, Breite: {0} cm",
                meinSchrank1.Laenge, meinSchrank1.Breite);
            Console.Write("meinSchrank2: ");
            Console.WriteLine("Länge: {0} cm, Breite: {0} cm",
                meinSchrank2.Laenge, meinSchrank2.Breite);

            // Erzeugen von 4 Schubfach - Objekten
            Schubfach schub1 = new Schubfach(100, 30, 15, farbe: "beige");
            Schubfach schub2 = new Schubfach(100, 30, 15, farbe: "rot");
            Schubfach schub3 = new Schubfach(100, 30, 15, farbe: "braun");
            Schubfach schub4 = new Schubfach(100, 30, 15, farbe: "weiß");
            // Kommode - Objekt erzeugen, das kopiert werden soll
            Kommode komm = new Kommode(100, 40, 100, 3.0, "hellbraun",
                      Material.Holz, 4, schub1,schub2, schub3, schub4);
            // Kopie von Kommode erzeugen
            Kommode komm2 = komm.Clone();
            Console.WriteLine("Farbe Schubfach1 von komm: " + 
                              komm.Schubfach1.Farbe);
            Console.WriteLine("Farbe Schubfach1 von komm2: " + 
                              komm2.Schubfach1.Farbe);
            // Schubfach1 der 2. Kommode ändern
            komm2.Schubfach1.Farbe = "grün";
            Console.WriteLine("Farbe Schubfach1 von komm: " + 
                               komm.Schubfach1.Farbe);
            Console.WriteLine("Farbe Schubfach1 von komm2: " + 
                               komm2.Schubfach1.Farbe);

            // Vergleich von Tisch - Objekten mittels Equals()
            Tisch esstisch1 = new Tisch(120, 90, 90, "blau");
            Tisch esstisch2 = new Tisch(120,90,90,"rot");

            // eigene Equals() - Methode zum Vergleichen genutzt
            // keine Beachtung von Gewicht, AnzTischbeine, Farbe
            // -> Eigenschaften unwichtig, 
            // wenn Tische zusammengestellt werden sollen
            if (esstisch1.Equals(esstisch2))
                Console.WriteLine("Tische sind gleich bei Laenge,Breite,Hoehe,Materialart");
            else
                Console.WriteLine("Tische sind ungleich");

            esstisch1.Materialart = Material.Glas;
            if (esstisch1.Equals(esstisch2))
                Console.WriteLine("Tische sind gleich bei Laenge,Breite,Hoehe,Materialart");
            else
                Console.WriteLine("Tische sind ungleich");

            Schreibtisch pctisch1 = new Schreibtisch();
            Schreibtisch pctisch2 = new Schreibtisch();

            if (pctisch1.Equals(pctisch2))
                Console.WriteLine("Die Schreibtische sind gleich");
            else
                Console.WriteLine("Die Schreibtisch sind nicht gleich");

            // Steckdosenleiste bei pctisch1 entfernen
            pctisch1.Steckdosenleiste = false;
            if (pctisch1.Equals(pctisch2))
                Console.WriteLine("Die Schreibtische sind gleich");
            else
                Console.WriteLine("Die Schreibtisch sind nicht gleich");


            // Verwendung der vorhandenen Referenzvariablen
            esstisch1 = new Tisch(165, 65, 90, "schwarz");
            esstisch2 = new Tisch(165, 65, 90, "schwarz");
            Console.WriteLine("Vergleich mittels ==:");
            // wird == nicht überladen,
            // werden nur die Adressen der beiden Objekte 
            // miteinander verglichen
            if (esstisch1 == esstisch2)
                Console.WriteLine("Tische sind gleich");
            else
                Console.WriteLine("Tische sind ungleich");

            if (esstisch1 != esstisch2)
                Console.WriteLine("Tische sind nicht gleich");
            else
                Console.WriteLine("Tische sind gleich");

            esstisch2.Farbe = "blau";
            if (esstisch1 == esstisch2)
                Console.WriteLine("Tische sind gleich");
            else
                Console.WriteLine("Tische sind ungleich");

            esstisch1 = esstisch1 + esstisch2;
            Console.WriteLine("zusammengestellter Tisch: {0}",esstisch1);
            esstisch1 = esstisch1 - esstisch2;
            Console.WriteLine("alter Tisch: {0}", esstisch1);

            Schrank s = new Schrank();
            Hilfsmethoden.Vergleichen(s);

            List<Schrank> liste = new List<Schrank>();
            liste.Add(new Schrank());
            liste.Add(new Schrank(300, 80, 200));
            liste.Add(new Schrank());
            liste.Add(new Schrank(180, 80, 200));
            liste.Add(new Schrank(300, 80, 200));
            liste.Add(new Schrank(150, 80, 180));
            liste.Add(new Schrank(300, 80, 200));

            Schrank gesuchterSchrank = new Schrank(300, 80, 200);
            int anz = Hilfsmethoden.Vergleichen(liste, gesuchterSchrank);
            if (anz == 0)
                Console.WriteLine("nicht in Liste enthalten");
            else
                Console.WriteLine("Anzahl: "+anz);

        } // Ende main()
    } // Ende der Klasse
}
