using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrundlagenWiederholung
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            Console.WriteLine("vorher: b = {0}",b);
            // && (doppeltes Und) ist ein Kurzschlussoperator:
            // - Vergleich mit && abgebrochen, 
            //   wenn erste Bedingung bereits false ergibt
            // - wird nur ein & verwendet, werden alle Bedingungen geprüft 
            // || (doppeltes Oder) ist ein Kurzschlussoperator:
            // - Vergleich mit || abgebrochen,
            //   wenn erste Bedingung bereits true ergibt 
            if (a < 0 && b++ < 20)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("nicht ok");
            }
            Console.WriteLine("nachher: b = {0}", b);

            Console.WriteLine("Variante 2:");
            Console.WriteLine("vorher: b = {0}", b);
            if (a < 0 & b++ < 20)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("nicht ok");
            }
            Console.WriteLine("nachher: b = {0}", b);
        }
    }
}
