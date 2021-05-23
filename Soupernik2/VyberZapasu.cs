using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Soupernik2
{
    internal class VyberZapasu
    {
        private Random randomizer;
        public VyberZapasu()
        {
            randomizer = new Random();
        }
        private List<Predvyber> PredvyberZpasy(List<Zapas> zapasy)
        {
            List<Predvyber> predvybery = new List<Predvyber>();
            foreach(var zapas in zapasy)
            {
                var bandy = new string[] { zapas.BandaE, zapas.BandaM };
                foreach(var banda in bandy)
                {
                    if (predvybery.Any(x => x.JmenoParty == banda))
                    {
                        Predvyber kZvyseni = predvybery.Where(x => x.JmenoParty == banda).SingleOrDefault();
                        kZvyseni.PocetZapasu++;
                    }
                    else
                    {
                        Predvyber naPridani = new Predvyber()
                        {
                            JmenoParty = banda,
                            PocetZapasu = 1
                        };
                        predvybery.Add(naPridani);
                    }
                }
            }
            predvybery = predvybery.OrderByDescending(x => x.PocetZapasu).ToList();
            return predvybery;
        }
        public Zapas VyberZapas(List<Zapas> zapasy, bool odstran)
        {
            var serazenyPredvyber = PredvyberZpasy(zapasy);
            var maloHraneBandy = serazenyPredvyber.Take(3).ToList();
            var naplanovac = new Naplanovac();
            var potencialniZapasy = naplanovac.Naplanuj(maloHraneBandy.Select(x => x.JmenoParty).ToList());
            var zapasyNaVyber = potencialniZapasy.Intersect(zapasy).ToList();


            int indexZapasu = randomizer.Next(0, zapasyNaVyber.Count());
            var vybranyZapas = zapasyNaVyber[indexZapasu];
            if (odstran)
            {
                zapasy.Remove(zapasyNaVyber[indexZapasu]);
            }

            return vybranyZapas;
        }
        private class Predvyber
        {
            public string JmenoParty { get; set; }
            public int PocetZapasu { get; set; }
        }

    }
}
