using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ParticialClassNedir
{
   public partial class Ogrenci
    {
        /*
         *Kontrol işlemleri: sistem içerisinde öğrenci kayıtlı mı? 71777000;
         * parametre kontrol işlemi: Giriş verileriniz hatalıdır. 71777001;
         * try catch : 71777002;
         * Başarılı : 71777003;
         * 
         * 
         * 71777014;
         */
        public int yeniKayit(Ogrenci o)
        {
            Console.WriteLine("Database kayıt işlemi tamamlandı.");
            return 1;
        }

        public int kayitGuncelle(Ogrenci o)
        {
            Console.WriteLine("Öğrenci kaydı güncellendi..");
            return 1;
        }

        public int kayitSil(Ogrenci O)
        {
            Console.WriteLine("öĞRENCİ kaydı silindi");
            return 1;
        }
    }
}
