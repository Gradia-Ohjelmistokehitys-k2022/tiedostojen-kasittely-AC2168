using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testi;

namespace testi
{
    static class Program_4
    {
        public static void Main()
        {
            FileStream x = File.Open("text1.txt", FileMode.Append);
            StreamWriter y = new(x);
            y.WriteLine("Toimiiko??");
            y.Close();

            FileStream z = File.Open("text1.txt", FileMode.Open, FileAccess.Read);
            StreamReader w = new(z);

            string? line;
            while ((line = w.ReadLine()) != null)
                Program_3.PrintList(line);

            w.Close();
        }
    }
    // avaa tekstitiedosto teksti1.txt peräänkirjoitusta varten.Tiedoston vanha sisältö säilyy avattaessa ja kirjoittaminen alkaa tiedoston lopusta.
    // tulosta tiedoston jo olemassa oleva sisältö.Käytä jotain kohdan 12.3. metodia.
    // lisää tiedostoon rivi ”Huuhaa!”
    // sulje tiedosto
    // avaa tekstitiedosto uudelleen vain lukemista varten
    // lue ja tulosta tiedoston sisältö rivi kerrallaan
    // sulje tiedosto





}