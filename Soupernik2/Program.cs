using System;
using System.Collections.Generic;
using System.Linq;



namespace Soupernik2
{
    class Program
    {
        static void Main(string[] args)
        {
            var zapasy = DeserializerZapasu.Deserializuj();
            var vysledky = DeserializerVysledku.DeserializujVysledky();
            if (vysledky == null)
            {
                vysledky = new List<Vysledek>();
            }
            


            Console.WriteLine("Vítej v programu Soupeřník 2.1");
            Console.WriteLine("Pokud chceš vybrat zápas, zmáčkni 1.");
            Console.WriteLine("Pokud chceš zadat výsledky zápasu, zmáčkni 2.");
            int vyber = int.Parse(Console.ReadLine());
            switch (vyber)
            {
                case 1:

                    VyberZapasu vyberZapasu = new VyberZapasu();


                    Console.WriteLine("Zmáčkni klávesu pro vybrání zápasu: ");
                    Console.ReadKey();
                    Console.WriteLine("Vybral jsem zápas: ");
                    var vybranyZapas = vyberZapasu.VyberZapas(zapasy, true);
                    Console.WriteLine($"Etik bude hrat: {vybranyZapas.BandaE} a Motik bude hrat: {vybranyZapas.BandaM}");
                    SerializerZapasu.Serializuj(zapasy);

                    // List<string> vysledky = new List<string>();
                    break;
                case 2:
                    while (Console.ReadKey().Key != ConsoleKey.Escape)
                    {
                        int maxId = 0;
                        if (vysledky.Count != 0)
                        {
                            maxId = vysledky.Select(v => v.IDZapasu).Max();
                        }
                        string vitez = "";
                        Zapas zapas = new Zapas();
                        int bodyVitez;
                        int bodyPorazeny;

                        Console.WriteLine("Zadej vítěze (zkratka bandy): ");
                        vitez = Console.ReadLine();
                        Console.WriteLine("Zadej koho hrál Etík: ");
                        zapas.BandaE = Console.ReadLine();
                        Console.WriteLine("Zadej koho hrál Motík: ");
                        zapas.BandaM = Console.ReadLine();
                        Console.WriteLine("Zadej počet bodů vítěze: ");
                        bodyVitez = int.Parse(Console.ReadLine());
                        Console.WriteLine("Zadej počřet bodů poraženého: ");
                        bodyPorazeny = int.Parse(Console.ReadLine());
                        ZadavacVysledku zadavac = new ZadavacVysledku();
                        vysledky = zadavac.ZadejVysledky(vysledky, vitez, zapas, bodyVitez, bodyPorazeny, maxId + 1);
                        Console.WriteLine("Pokud chceš skončit s vkládáním výsledků, zmáčkni Esc");
                    }



                    SerializerVysledku.SerializujVysledky(vysledky);
                    break;
            }
            if ((vyber < 1) && (vyber > 2))
            {
                Console.WriteLine("Neplatná volba.");
            }

        }

    }
}
