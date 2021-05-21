using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Soupernik2
{
    public static class DeserializerVysledku
    {
        public static List<Vysledek> DeserializujVysledky()
        {
            var cestaKSouboru = Path.GetFullPath(Konstanty.CestyKSouborum.SouborVysledky);
            return JsonConvert.DeserializeObject<List<Vysledek>>(File.ReadAllText(cestaKSouboru));
        }
    }
}
