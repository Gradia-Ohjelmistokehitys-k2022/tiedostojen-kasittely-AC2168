using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testi;

namespace testi
{
    public static class Program_3
    {
        public static void PrintTable<T>(T title, string line)
        {
            #region Prevent overflow
            int strlen = line.Length;
            int conlen = Console.WindowWidth;

            if (strlen > conlen - 4)
            {
                line = string.Concat(line.AsSpan(0, conlen - 7), "...");
                strlen = line.Length;
            }

            int len = Math.Min(conlen, strlen);
            #endregion

            string sep = new('-', len + 4);

            Console.WriteLine(sep);
            Console.WriteLine("| Line " + title?.ToString()?.PadRight(len - 5) + " |");
            Console.WriteLine(sep);
            Console.WriteLine("| " + line.PadRight(len) + " |");
            Console.WriteLine(sep);
        }

        public static void PrintList(string line)
        {
            Console.WriteLine("* " + line);
        }

        public static void PrintString(string line)
        {
            Console.WriteLine(line);
        }

        public static void Main()
        {
            if (!File.Exists("text1.txt"))
                return;

            FileStream x = File.OpenRead("text1.txt");
            StreamReader reader = new(x);

            string? line;
            int loops = 0; 
            while ((line = reader.ReadLine()) != null)
            {
       
                PrintTable(loops ++, line);
                PrintList(line);
                PrintString(line);
            }
        }
        // tässä sain apua 
        // tarkista ennen avaamista onko teksti1.txt olemassa. Tee 12.1 -kohdan pääohjelman koodista tarvittaessa oma metodi +bool OnOlemassa(string nimi); Jos tiedosto on olemassa:
        // avaa tekstitiedosto teksti1.txt
       // Tee metodit, jotka lukevat rivit rivi kerrallaan a) taulukoksi b) listaksi c) merkkijonoksi(string)
        // tulosta a, b ja c -kohtien tiedot
        // sulje tiedosto
    }
}