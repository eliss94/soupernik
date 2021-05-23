using ConsoleTableExt;
using Soupernik2;
using System;

namespace Tabulkovnik
{
    class Program
    {
        static void Main(string[] args)
        {
            var tableData = DeserializerVysledku.DeserializujVysledky();
            Console.WriteLine("Ahoj, vítej v Tabulkovníku");
            Console.WriteLine("Pokud chceš vypsat tabulku sumarizovaných výsledků zmáčkni 1");
            Console.WriteLine("Pokud chceš vypsat seznam zápasů s výsledky 2");

            int vyber = int.Parse(Console.ReadLine());
            switch (vyber)
            {
                case 1:
                    var sumarizer = new SumarizerVysledku();
                    var tableData2 = sumarizer.SumarizaceVysledku(tableData);

                    ConsoleTableBuilder
                     .From(tableData2)
                     .ExportAndWriteLine();
                    break;
                case 2:

                    ConsoleTableBuilder
                      .From(tableData)
                      .ExportAndWriteLine();
                    break;
            }
        }
    }
}
