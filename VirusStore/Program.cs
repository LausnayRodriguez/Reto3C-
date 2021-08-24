using System;
using System.Collections.Generic;
using VirusStore.Engine;
using VirusStore.Entities;
using VirusStore.Utilities;
using static System.Console;

namespace VirusStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new VirusStoreEngine();
            engine.Inicializador();
            Printer.WriteTitle("STOCK STORE");
            PrintStock(engine.VirusStocker);
            ReadLine();
            
        }

        private static void PrintStock(VirusStock Stock)
        {

            Printer.WriteTitle("CATEGORIAS DE LA TIENDA");


            if (Stock?.Categories != null)
            {
                foreach (var category in Stock.Categories)
                {
                    WriteLine($"Nombre {category.Name  }, Id  {category.ID}");
                }
            }
        }
    }
}
