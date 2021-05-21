using System;
using System.Collections.Generic;
using System.Text;

namespace Soupernik2
{
    public class Zapas
    {
        public string BandaE { get; set; }
        public string BandaM { get; set; }

        public override string ToString()
        {
            return BandaE + ":" + BandaM;
        }
    }
}
