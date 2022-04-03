using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testi;

namespace testi
{
    static class Program_6  
    {
        public static void Main()
        {
            // Pitää olla tiedosto jo luotuna !!!!!!
            if (!File.Exists("binaari.bin"))
                File.Create("binaari.bin").Close();

            FileStream x = File.Open("binaari.bin", FileMode.Truncate, FileAccess.ReadWrite);
            BinaryWriter bw = new(x);

            unchecked
            {
                bw.Write((float)Math.PI);
                bw.Write((int)4294967295);
                bw.Flush();
                x.Position = 0;
            }

            BinaryReader br = new(x);
            float f = br.ReadSingle();
            int i = br.ReadInt32();

            Console.WriteLine("{0} {1}", f, i);
            x.Close();
            br.Dispose();
            bw.Dispose();
        }
    }
}

// -Avaa (luo) tiedosto oma_binaari.bin kirjoittamista varten. Vanha sisältö saa nollautua avattaessa. 
// kirjoita tiedostoon liukuluku 3,14159265 ja kokonaisluku -1 -sulje tiedosto -avaa tiedosto -lue tiedostosta arvot float f ja int i ja tulosta ne. -sulje tiedosto -tarkastele tiedoston sisältöä tekstieditorilla (notepad tms.) ja kerro mitä näet. Vihje: ei saa näkyä 3,14159265-1
