using System;
using System.Collections.Generic;
using System.IO;

namespace testi
{
    static class Program_1
    {
        static Dictionary<string, string> ParseArgs(string[] args)
        {

            Dictionary<string, string> result = new();

            for (int i = 0, last = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("--"))
                {
                    last = i;
                    result[args[i]] = args[++i];
                }
                else
                {
                    result[args[last]] += ' ' + args[i];
                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            Dictionary<string, string> parsed = ParseArgs(args);
            parsed.TryGetValue("tiedosto", out string? filename);

            if (filename == null)
            {
                Console.WriteLine("tiedostoa ei ole olemassa.");
                Environment.Exit(1);
            }

            const string exist = "Testi: tiedosto on olemassa";
            const string notexist = "Testi: tiedosto ei ole olemassa";
            const string dir = "Testi: on hakemistossa";

            if (File.Exists(filename)) Console.WriteLine(exist, filename);
            else if (Directory.Exists(filename)) Console.WriteLine(dir, filename);
            else Console.WriteLine(notexist, filename);
        }
    }
    //täysin  itse tehty
    //12.1 Luo uusi luokka, jonka nimi on Tiedosto
    //Tee pääohjelma(main), joka kysyy tiedoston nimen ja tulostaa tiedon siitä onko annetun niminen tiedosto olemassa.
}