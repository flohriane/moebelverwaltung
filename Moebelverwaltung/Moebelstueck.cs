using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
   /// <summary>
   /// abstrakte Basisklasse, die Eigenschaften und Methoden
   /// für ein Möbelstück definiert
   /// </summary>
   
   // von abstrakter Klasse keine Objekte erzeugbar
   // Klasse muss abgeleitet (vererbt) werden
   public abstract class Moebelstueck
    {
        #region Eigenschaften
        // generierter Code mittels Code-Snippet propfull + zweimal Tab
        private int laenge;
        /// <summary>
        /// Länge des Möbelstücks in cm
        /// </summary>
        public int Laenge
        {
            get { return laenge; }
            set { laenge = value; }
        }
        // generierter Code mittels Code-Snippet prop + zweimal Tab
        /// <summary>
        /// Breite des Möbelstücks in cm
        /// </summary>
        public int Breite { get; set; }

        // generierter Code mittels Code-Snippet propg + zweimal Tab
        // Eigenschaft kann nur innerhalb der Klasse gesetzt werden
        // Eigenschaft außerhalb der Klasse nur lesbar
        // public int MyProperty { get; private set; }

        /// <summary>
        /// Höhe des Möbelstücks in cm
        /// </summary>
        public int Hoehe { get; set; }

        /// <summary>
        /// Gewicht des Möbelstücks in kg
        /// </summary>
        public double Gewicht { get; set; }
        /// <summary>
        /// Farbe des Möbelstücks
        /// </summary>
        public string Farbe { get; set; }
        /// <summary>
        /// Materialart des Möbelstücks: Holz,Stahl,Glas,Kunststoff
        /// </summary>
        public Material Materialart { get; set; }
        #endregion


        protected Moebelstueck(int laenge, int breite, int hoehe, double gewicht,
                               string farbe, Material materialart)
        {
            Console.WriteLine("Moebelstueck(alle Parameter)");
            Laenge = laenge;
            Breite = breite;
            Hoehe = hoehe;
            Gewicht = gewicht;
            Farbe = farbe;
            Materialart = materialart;
        }

        // voll implementierte Methode
        /// <summary>
        /// gibt einen String zurück, der angibt,
        /// in welcher Firma das Möbelstück hersgestellt wird
        /// </summary>
        /// <param name="firma">String, der den Firmennamen enthält</param>
        /// <returns>string - Text inkl. Firmenname</returns>
        // virtual kennzeichnet eine Methode als überschreibbar
        public virtual string Herstellen(string firma)
        {
            return string.Format("Das Möbelstück wird von Fa. {0} hergestellt. ", firma);
        }

        // abstrakte Methode, 
        // die in abgeleiteten Klassen überschrieben werden muss
        // Syntax: public abstract Rückgabetyp Methodenname(Parameterliste);
        /// <summary>
        /// berechnet den Bruttopreis des Möbelstücks
        /// </summary>
        /// <returns>double - Bruttopreis</returns>
        public abstract double BerechnePreis();
    }
}
