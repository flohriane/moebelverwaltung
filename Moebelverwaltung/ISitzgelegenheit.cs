using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    // Interfaces können nur abstrakte Methode
    // und Eigenschaften beinhalten
    /// <summary>
    /// beinhaltet Methoden für Möbel, auf denen man sitzen kann
    /// </summary>
    public interface ISitzgelegenheit
    {
        // alle Methoden in einem Interface 
        // sind generell public und abstract
        // -> diese Schlüsselwörter dürfen nicht verwendet werden
        /// <summary>
        /// gibt zurück, wie die Sitzqualität ist
        /// </summary>
        /// <param name="qualitaet">z.B. gut, sehr gut, nicht so gut</param>
        /// <returns>string</returns>
        string Sitzen(string qualitaet);
        // Eigenschaft Polster ebenfalls public
        /// <summary>
        /// gibt an, ob Stuhl gepolstert ist
        /// </summary>
        bool Polster { get; set; } 
    }
}
