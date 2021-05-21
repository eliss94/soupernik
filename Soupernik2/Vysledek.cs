using System;
using System.Collections.Generic;
using System.Text;

namespace Soupernik2
{
    public class Vysledek
    {
        public int IDZapasu { get; set; }
        public Zapas Zapas { get; set; }
        public string Vitez { get; set; }
        public int BodyVitez { get; set; }
        public int BodyPorazeny { get; set; }

    }
}
