using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbilYonetimiEntityLayer.Entities
{
   public class Talimat: IIdProperty
    {
        
        public DateTime OlusturmaTarihi { get; set; }
        public string AkbilID { get; set; }
        public decimal YuklenecekMiktar { get; set; }
        public bool YuklendiMi { get; set; }
        public DateTime? YuklendigiTarihi { get; set; }//Null olamayacak bir tipi Soru işareti null yapıyor
        public int Id { get; set; }
    
    }
}
