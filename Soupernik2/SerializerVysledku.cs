using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Soupernik2
{
    public static class SerializerVysledku
    {
        public static void SerializujVysledky(List<Vysledek> vysledky)
        {
            var cestaKSouboru = Path.GetFullPath(Konstanty.CestyKSouborum.SouborVysledky);
            System.Console.WriteLine("Ukladame do souboru: " + cestaKSouboru);

            File.WriteAllText(cestaKSouboru, JsonConvert.SerializeObject(vysledky));

        }
    }
}
