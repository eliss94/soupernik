using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace Soupernik2
{
    public static class DeserializerZapasu
    {
        public static List<Zapas> Deserializuj()
        {
            var cestaKSouboru = Path.GetFullPath(Konstanty.CestyKSouborum.SouborZapasy);
            return JsonConvert.DeserializeObject<List<Zapas>>(File.ReadAllText(cestaKSouboru));
        }
    }
}
