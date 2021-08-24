using System;
using static System.Console;

namespace VirusStore.Utilities
{
    class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            WriteLine("".PadLeft(tam, '='));
        }

        public static void WriteTitle(string titulo)
        {
            var tamaño = titulo.Length + 4;
            DibujarLinea(tamaño);
            WriteLine($"| {titulo} |");
            DibujarLinea(tamaño);
        }        
    }
}
