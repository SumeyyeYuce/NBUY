using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ShoppingApp.Web.Areas.Admin.Models.Dtos
{
    
    public class CategoryUpdateDto
    {
        public int Id { get; set; }

        [DisplayName("Kategori Adı")] //ekranda gözükücek isim
        [Required(ErrorMessage = "{0}  boş bırakılmamalıdır")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakter kısa olmamaldır")]
        [MaxLength(50, ErrorMessage = "{0} , {1} karakterden uzun olmamaıldır")]

        public string Name { get; set; }
        [DisplayName("Kategori Açıklaması")]
        [Required(ErrorMessage = "{0}  boş bırakılmamalıdır")]
        [MinLength(10, ErrorMessage = "{0} , {1} karakter kısa olmamaldır")]
        [MaxLength(500, ErrorMessage = "{0} , {1} karakterden uzun olmamaıldır")]
        public string Description { get; set; }

        [DisplayName("Kategori Url")]
        [Required(ErrorMessage = "{0}  boş bırakılmamalıdır")]
      
        public string Url { get; set; }
    }
}
