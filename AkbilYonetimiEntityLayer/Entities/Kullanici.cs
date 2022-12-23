using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkbilYonetimiEntityLayer.Entities
{
    public class Kullanici:IIdProperty,IKayitTarihiProperty
    {
        [StringLength(50,ErrorMessage ="İsim alanı en fazla 50 olmalıdır!")]//Kapsülleme işlemi yerine İstediğimiz publicin üstüne yazılır.
        public string Isim { get; set; }
        [StringLength(50, ErrorMessage = "İsim alanı en fazla 50 olmalıdır")]
        public string Soyisim { get; set; }
        [EmailAddress]

        public string Email { get; set; }
        public string Parola { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Id { get; set; }
        public DateTime KayitTarihi { get; set; }
    }
}
