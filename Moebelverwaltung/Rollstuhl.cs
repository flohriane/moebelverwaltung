using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    public class Rollstuhl : Stuhl, IFahrbarerUntersatz
    {
        public string Fahren()
        {
            return "Mit Rollen dran kann ich fahren.";
        }
    }
}
