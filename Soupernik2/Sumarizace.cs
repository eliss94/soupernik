using System;
using System.Collections.Generic;
using System.Text;

namespace Soupernik2
{
    public class Sumarizace
    {
        public string JmenoParty { get; set; }
        public int PocetZapasu { get; set; }
        public int PocetVyher { get; set; }
        public int BodyPlus { get; set; }
        public int BodyMinus { get; set; }
        public int RozdilSkore => BodyPlus - BodyMinus;
        public double ProcentoVyher => (((double)PocetVyher / PocetZapasu) * 100);
    }
}
