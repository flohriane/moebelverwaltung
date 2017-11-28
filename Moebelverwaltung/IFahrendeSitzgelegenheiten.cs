using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBW.Moebelverwaltung
{
    // ein Interface kann mehrere Interfaces erweitern
    public interface IFahrendeSitzgelegenheiten
        : IFahrbarerUntersatz, ISitzgelegenheit
    {
        double Geschwindigkeit { get; set; }    
    }
}
