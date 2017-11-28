using BBW.Moebelverwaltung;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoebelvewaltungAnwendung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klasse sowie deren Member müssen public sein,
            // um sie in diesem Projekt verwenden zu können
            Tisch t1 = new Tisch();
            Console.WriteLine(t1.ToString());

            List<Tisch> tische = new List<Tisch>();
            tische.Add(new Tisch(100, 80, 90, "braun"));
            tische.Add(new Tisch(150, 80, 90, "hellbraun"));
            tische.Add(new Tisch(180, 80, 90, "rotbraun"));
            tische.Add(new Tisch(110, 80, 90, "blau"));
            tische.Add(new Tisch(200, 80, 90, "dunkelbraun"));
            tische.Add(new Tisch(170, 80, 90, "beige"));
            tische.Add(new Tisch(175, 100, 90, "grün"));
            tische.Add(new Tisch(90, 90, 90, "weiß"));
            // item ist eine lokale Variable und kann in einer
            // neuen Schleife wieder verwendet werden
            foreach (var item in tische)
            {
                Console.WriteLine(item.ToString());
            }

            // Aufgabe: alle braunen Tische in einer separaten Liste speichern
            // Lösung Variante 1:
            List<Tisch> listeBrauneTische = new List<Tisch>();
            foreach (var item in tische)
            {
                string farbe = item.Farbe;
                if(farbe.Contains("braun"))
                {
                    listeBrauneTische.Add(item);
                }
            }
            Console.WriteLine("Braune Tische: ");
            for (int i = 0; i < listeBrauneTische.Count; i++)
            {
                Console.WriteLine(listeBrauneTische[i].ToString());
            }

            // Lösung Variante 2:
            // Verwendung von LINQ (Language Intergrated Query)
            // Syntax: from Bereichsvariable in Liste
            //         where Bedingung(en)
            //         select Bereichsvariable;
            // Rückgabe ist ein Objekt vom Typ IEnumerable<Tisch>
            // LINQ - Abfrage erst ausgeführt,
            // wenn auf Ergebnismenge zugegriffen wird 
            // (wenn Liste mittels foreach durchlaufen wird) 
            // Tische zusätzlich nach der Länge sortieren
            // Bereichsvariable tisch hier definiert und intialisiert
            var listeBrauneTische2 = from tisch in tische
                                     where tisch.Farbe.Contains("braun")
                                     // absteigende Sortierung der Länge
                                     // ascending = aufsteigend
                                     // descending = absteigend
                                     orderby tisch.Laenge descending
                                     select tisch;
            Console.WriteLine("Braune Tische - Variante 2:");
            foreach (var item in listeBrauneTische2)
            {
                Console.WriteLine(item.ToString());
            }

            // Lösung Variante 3:
            // Erweiterungsmethodensyntax von LINQ
            // Verwendung von Lambda - Ausdrücken
            // Syntax: Methodenname((Parameter1) => Parameter1.Eigenschaft ==Value)
            var listeBrauneTische3 = tische
                                    .Where((tisch1) => tisch1.Farbe.Contains("braun"))
                                    .OrderByDescending((tisch2) => tisch2.Laenge);
            Console.WriteLine("Braune Tische - Variante 3:");
            foreach (var item in listeBrauneTische3)
            {
                Console.WriteLine(item.ToString());
            }


            // Anzahl der braunen Tische ermitteln (Abfrage-Syntax)
            // Abfrage sofort ausgeführt
            int anzahlBrauneTische = (from tisch in tische
                                      where tisch.Farbe.Contains("braun")
                                      select tisch).Count();
            Console.WriteLine("Anzahl braune Tische: " + anzahlBrauneTische);
        }
    }
}
