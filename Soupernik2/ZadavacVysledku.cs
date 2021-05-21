using System;
using System.Collections.Generic;
using System.Text;

namespace Soupernik2
{
    public class ZadavacVysledku
    {
        public ZadavacVysledku()
        {

        }
        public List<Vysledek> ZadejVysledky(List<Vysledek> vysledky, string vitez, Zapas zapas, int bodyVitez, int bodyPorazeny, int idzapasu)
        {
            Vysledek vysledek = new Vysledek();
            vysledek.IDZapasu = idzapasu;
            vysledek.Vitez = vitez;
            vysledek.Zapas = zapas;
            vysledek.BodyVitez = bodyVitez;
            vysledek.BodyPorazeny = bodyPorazeny;
            vysledky.Add(vysledek);
            
            return vysledky;
        }
    }
}
