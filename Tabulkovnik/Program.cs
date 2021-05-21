using ConsoleTableExt;
using Soupernik2;
using System;
using System.Collections.Generic;

namespace Tabulkovnik
{
    class Program
    {
        static void Main(string[] args)
        {
            var tableData = DeserializerVysledku.DeserializujVysledky();

            ConsoleTableBuilder
            .From(tableData)
            .ExportAndWriteLine();
        }
    }
}
