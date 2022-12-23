using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbilYonetimiEntityLayer.Entities
{
  public class Akbil:IKayitTarihiProperty
    {
        [StringLength(16,MinimumLength =16,ErrorMessage ="Akbil Seri Numarası 16 Haneli Olmalıdır")]
        public string AkbilNo { get; set; }
        public decimal Bakiye { get; set; }
        public DateTime SonKullanim { get; set; }     
        public int AkbilSahibi { get; set; }
        public AkbilTipleri AkbilTipi { get; set; }
        public DateTime KayitTarihi { get; set; }

        //Akbil Tipi Gelecek
    }
    
}
