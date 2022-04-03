using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using testi;

namespace testi
{
    static class Program_5
    {
        public static void Main()
        {
            FileStream x = File.Open("text1.txt", FileMode.Open, FileAccess.Read);

            Span<byte> buffer = new(new byte[x.Length]);
            x.Read(buffer);

            Console.WriteLine(string.Join(',', buffer.ToArray()));
        }
    }
}
// käytän kaikissa using testiä koska haluun että kaikki toimii ei varmaan edes ole pakollinen näissä!
// avaa tektitiedosto teksti1.txt lukemista varten
// lue tiedoston sisältö merkki (char) kerrallaan ja tulosta luetut merkit pilkulla erotettuna.
//sulje tiedosto. Malli: H,e,l,l,o, ,w,o,r,l,d,!,

