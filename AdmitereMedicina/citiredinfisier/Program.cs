using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace citiredinfisier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
           
            var Text = File.ReadAllLines(@"C:\Users\H232112\Desktop\Clau\Med.txt", Encoding.UTF8);
            for (int i = 0; i < Text.Length; i++)
            {
                string linie = Text[i];
                var procesarelinie = linie.Split('@');
                Console.WriteLine("Continut intrebare:" + procesarelinie[0]);
                Console.WriteLine("Raspunsul Corect este: " + procesarelinie[2]);
                var variante = procesarelinie[1].Replace('|', '\n');
                Console.WriteLine(variante);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
