using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Soupernik2
{
    public static class SerializerZapasu
    {
        public static void Serializuj(List<Zapas> zapasy)
        {
            var cestaKSouboru = Path.GetFullPath(Konstanty.CestyKSouborum.SouborZapasy);
            System.Console.WriteLine("Ukladame do souboru: " + cestaKSouboru);
            
            File.WriteAllText(cestaKSouboru, JsonConvert.SerializeObject(zapasy));

        }
    }
}
