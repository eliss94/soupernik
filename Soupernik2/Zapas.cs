using System;
using System.Collections.Generic;
using System.Text;

namespace Soupernik2
{
    public class Zapas : IEquatable<Zapas>
    {
        public string BandaE { get; set; }
        public string BandaM { get; set; }

        public override bool Equals(object obj)
        {
            var objectKPorovanani = obj;
            if(this.BandaE == ((Zapas)objectKPorovanani).BandaE && this.BandaM == ((Zapas)objectKPorovanani).BandaM)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Equals(Zapas other)
        {
            return Equals(other as object);
        }

        public override int GetHashCode()
        {
            return (BandaE, BandaM).GetHashCode();
        }

        public override string ToString()
        {
            return BandaE + ":" + BandaM;
        }
    }
}
