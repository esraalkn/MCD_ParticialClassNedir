using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ParticialClassNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.id = 1;
            m1.isim = "esra";
            m1.soyisim = "alkan";
            m1.emailAdres = "es.alknn@gmail.com";

            int sonuc = m1.yeniKayit(m1);
            if (sonuc > 0)
            {
                Console.WriteLine("Database yeni kayit eklendi");
            }

            Ogrenci o1 = new Ogrenci();
            o1.id = 1;
            int ogrencikayitsonuc = o1.yeniKayit(o1);

            if (ogrencikayitsonuc == 71777000)
            {

            }
           else if (ogrencikayitsonuc == 71777001)
            {

            }
            if (ogrencikayitsonuc == 71777002)
            {

            }
            if (ogrencikayitsonuc == 71777003)
            {

            }
            if (ogrencikayitsonuc == 71777004)
            {

            }
            else
            {

            }
        }
    }
}
