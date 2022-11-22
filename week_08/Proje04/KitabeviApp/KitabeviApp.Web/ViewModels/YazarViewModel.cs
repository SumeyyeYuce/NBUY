using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KitabeviApp.ViewModels
{
    public class YazarViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Lütfen adı boş bırakmayın")]
        [StringLength(30,ErrorMessage ="Lüften 30 karakterden daha fazla girmeyiniz")]
        [Display(Name ="Yazar Adı Soyadı:",Prompt ="Lütfen yazar ad soyadını giriniz...")]
        public string Ad { get; set; }
        
        [Required(ErrorMessage ="Lütfen dogum yılını yazınız")]
        [Display(Name ="Yazar DogumYılı:",Prompt ="2000...")]
        public int? DogumYili { get; set; }

        public char Cinsiyet { get; set; }
    }
}