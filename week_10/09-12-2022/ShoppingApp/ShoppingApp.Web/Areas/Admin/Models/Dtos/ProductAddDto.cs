using ShoppingApp.Entity.Concrete;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShoppingApp.Web.Areas.Admin.Models.Dtos
{
    public class ProductAddDto
    {

        [DisplayName("Ürün Adı")] //ekranda gözükücek isim
        [Required(ErrorMessage = "{0}  boş bırakılmamalıdır")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakter kısa olmamaldır")]
        [MaxLength(100, ErrorMessage = "{0} , {1} karakterden uzun olmamaıldır")]

        public string Name { get; set; }


        [DisplayName("Ürün Fiyatı")] 
        [Required(ErrorMessage = "{0}  boş bırakılmamalıdır")]
        public decimal? Price { get; set; }

        [DisplayName("Açıklama")] 
        [Required(ErrorMessage = "{0}  boş bırakılmamalıdır")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakter kısa olmamaldır")]
        [MaxLength(500, ErrorMessage = "{0} , {1} karakterden uzun olmamaıldır")]
        public string Description { get; set; }

        [DisplayName("Ürün Resmi")] 
        [Required(ErrorMessage = "{0}  seçilmelidir")]
        public IFormFile ImageFile { get; set; }

        [DisplayName("Anasayfa ürünü")] 
        public bool IsHome { get; set; }


        [DisplayName("Onaylı ürün?")] 
        public bool IsApproved { get; set; }

        [DisplayName("Kategoriler")] 
        public List<Category>  Categories { get; set; }

        [Required(ErrorMessage = "En az bir kategori seçilmeli")]
        public List<Category> SelectedCategories { get; set; }

    }
}
