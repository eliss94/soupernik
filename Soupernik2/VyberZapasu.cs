using System;
using System.Collections.Generic;
using System.Text;

namespace Soupernik2
{
    internal class VyberZapasu
    {
        private Random randomizer;
        public VyberZapasu()
        {
            randomizer = new Random();
        }
        public Zapas VyberZapas(List<Zapas> zapasy, bool odstran)
        {
            int indexZapasu = randomizer.Next(0, zapasy.Count);
            var vybranyZapas = zapasy[indexZapasu];
            if (odstran)
            {
                zapasy.Remove(zapasy[indexZapasu]);
            }

            return vybranyZapas;
        }

    }
}
