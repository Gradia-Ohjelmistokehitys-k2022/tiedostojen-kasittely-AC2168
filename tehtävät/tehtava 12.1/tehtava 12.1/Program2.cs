using testi;
using System;
using System.Collections.Generic;
using System.IO;

namespace testi
{
    static class Program_2
    {
        public static void Main(string[] vs)
        {

            Program_2.Main(new string[]
            {

                "--tiedosto",
                "Paikka"
            });

 
            FileStream x = File.Create("text1.txt");
            Span<byte> data = new(new byte[]
            {
                0x48, 0x65, 0x6C, 0x6C,
                0x6F, 0x2C, 0x20, 0x77,
                0x6F, 0x72, 0x6C, 0x64,
                0x21, 0x0A
            });

            x.Write(data);
        }
    }
    // löysin apua netistä tähän 
}

// Jatka tehtävän 12.1 pääohjelmaa:
// luo ja avaa tekstitiedosto teksti1.txt siten, että sen sisältö tyhjenee, kun se avataan.
// Kirjoita tiedostoon rivi ”Hello world!”
// Kirjoita tiedostoon rivi ”Uusi rivi tässä.”
// sulje tiedosto

