using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KitabeviApp.Models
{
    //   [Required] zorunluluk
    //ctrl+shift+h isim değişimi yapıyor
    public class Yazar
    {
        public int Id { get; set; }

        // [Required(ErrorMessage ="Lütfen adı boş bırakmayınız!")]
        public string Ad { get; set; }

        // [Required(ErrorMessage ="Lütfen doğum yılını boş bırakmayınız")]
        public int? DogumYili { get; set; }

        public char Cinsiyet { get; set; }
    }
}