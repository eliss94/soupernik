using System;
using System.Collections.Generic;
using System.Text;

namespace Soupernik2
{
    public class Naplanovac
    {
        public Naplanovac()
        {
        }
        public List<Zapas> Naplanuj(List<string> tymy)
        {
            List<Zapas> zapasy = new List<Zapas>();
            for (int i = 0; i < tymy.Count; i++)
            {
                for (int j = 0; j < tymy.Count; j++)
                {
                    if (j != i)
                    {
                        Zapas zapasNaPridani = new Zapas();
                        zapasNaPridani.BandaE = tymy[i];
                        zapasNaPridani.BandaM = tymy[j];
                        zapasy.Add(zapasNaPridani);
                    }
              
                }
            }
            return zapasy;
        }
    }
}
