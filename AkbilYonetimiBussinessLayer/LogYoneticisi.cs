using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbilYonetimiBussinessLayer
{
   public static class LogYoneticisi
    {
        public static void LoguYaz(string mesaj)
        {
            try
            {
                // Log---> Programa ait hata mesajı ya da bilgileri tuttuğumuz kayıtlardır
                //Loglar txt dosyasında tutulabilir
                //Loglar veritabanındaki log tablolarına yazılabilir
                //Loglamayı kolaylaştıran NLog tarzı paketler indirilebilir.
                string dosyaAdi = $"AkbilYonetimProjesi_{DateTime.Now.ToString("yyyyMMdd")}.txt";
                string dosyaYolu = Path.Combine(Environment.GetFolderPath
                (Environment.SpecialFolder.Desktop), dosyaAdi);
                StreamWriter yazici = new StreamWriter(append: true, path: dosyaYolu);
                yazici.AutoFlush = true;
                yazici.WriteLine($"{DateTime.Now.ToString()}-{mesaj}");
                yazici.Close();

            }
            catch (Exception hata)
            {
                //loglamada problem var ise email atılabilir
                //Db'ye kaydedilebilir.
              

            }


        }
    }
}
