using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Soupernik2
{
    public class SumarizerVysledku
    {
        public SumarizerVysledku()
        {

        }
        public List<Sumarizace> SumarizaceVysledku(List<Vysledek> vysledky)
        {
            List<Sumarizace> sumarizovaneVysledky = new List<Sumarizace>();
            foreach(var vysledek in vysledky)
            {
                var bandy = new string[] { vysledek.Zapas.BandaE, vysledek.Zapas.BandaM };
                foreach (var banda in bandy)
                {
               
                    if (sumarizovaneVysledky.Any(x => x.JmenoParty == banda))
                    {
                        Sumarizace kPridani = sumarizovaneVysledky.Where(x => x.JmenoParty == banda).SingleOrDefault();
                        kPridani.PocetZapasu++;
                    }
                    else 
                    {
                        Sumarizace novaSumarizace = new Sumarizace()
                        {
                            JmenoParty = banda,
                            PocetZapasu = 1
                        };
                        sumarizovaneVysledky.Add(novaSumarizace);
                    }
                    Sumarizace pridani = sumarizovaneVysledky.Where(x => x.JmenoParty == banda).SingleOrDefault();

                    if (vysledek.Vitez == banda)
                    {
                        pridani.PocetVyher++;
                        pridani.BodyPlus += vysledek.BodyVitez;
                        pridani.BodyMinus += vysledek.BodyPorazeny;
                    }
                    else
                    {
                        pridani.BodyPlus += vysledek.BodyPorazeny;
                        pridani.BodyMinus += vysledek.BodyVitez;
                    }

                }
            }
            sumarizovaneVysledky = sumarizovaneVysledky
                .OrderByDescending(x => x.PocetVyher)
                .ThenByDescending(x => x.RozdilSkore)
                .ThenByDescending(x => x.ProcentoVyher).ToList();

            return sumarizovaneVysledky;
        }

        
    }
}
