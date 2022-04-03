using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using testi;

namespace testi
{
    static class Program_7
    {
        public static void Main(string[] args)
        {
            string dir = args.Length > 0 ? args[0] : ".";
            string[] dre = Directory.GetFileSystemEntries(dir);
            Array.Sort(dre, (x, y) => y.Length - x.Length);


            Console.WriteLine("paivamaara        aika      koko          paikka");
            foreach (string fsent in dre)
            {
                string path = Path.Combine(dir, fsent);
                bool isDir = Directory.Exists(path);
                bool isFile = File.Exists(path);

                StringBuilder @string = new();

                DateTime cd;
                if (isFile) cd = File.GetCreationTime(path);
                else cd = Directory.GetCreationTime(path);

                @string.Append(cd.ToShortDateString().PadRight(12));
                @string.Append(cd.ToShortTimeString().PadLeft(8, '0').PadRight(10));

                long size = 0;
                if (isFile) size = new FileInfo(path).Length;
                @string.Append(size.ToString().PadRight(12) + "  ");

                @string.Append(fsent);
                if (isDir) @string.Append('\\');
                if (isFile)               

                Console.WriteLine(@string);
            }
        }
    }
}









// Tee ohjelma, joka tulostaa hakemiston sisällön. Kerro myös tiedostojen pvm + koko.
