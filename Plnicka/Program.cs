using Soupernik2;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Plnicka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vygenerovat novy soubor zapasu? Vymaze stary stav! A/N?");
            if(Console.ReadKey().Key == ConsoleKey.A)
            {
                List<string> tymy = new List<string>() { "GD", "DP", "SWH", "TP", "RS", "YG", "MP" };
                Naplanovac naplanovac = new Naplanovac();
                var zapasy = naplanovac.Naplanuj(tymy);

                SerializerZapasu.Serializuj(zapasy);

                //Console.WriteLine($"Serializoval jsem zapasy: {String.Join(',', zapasy.Select(z => $"{z.BandaE}:{z.BandaM}"))}");
            }

            Console.WriteLine("Vygenerovat novy soubor vysledku? Vymaze stary stav! A/N?");
            if (Console.ReadKey().Key == ConsoleKey.A)
            {
                var vysledky = new List<Vysledek>();

                SerializerVysledku.SerializujVysledky(vysledky);

                //Console.WriteLine($"Serializoval jsem zapasy: {String.Join(',', zapasy.Select(z => $"{z.BandaE}:{z.BandaM}"))}");
            }
        }
    }
}
