using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Web.Areas.Admin.Models.Dtos
{
    public class FoodAddDto
    {
        [DisplayName("Yemek Adı")]
        [Required(ErrorMessage ="{0} boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olamaz")]
        
        public string Name { get; set; }

        [DisplayName("Malzemeler")]
        [Required(ErrorMessage = "{0} boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olamaz")]
        [MaxLength(100, ErrorMessage = "{0} , {1} karakterden uzun olamaz")]
        public string Material { get; set; }

        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olamaz")]
        [MaxLength(500, ErrorMessage = "{0} , {1} karakterden uzun olamaz")]
        public string Description { get; set; }

        [DisplayName("Yemek Resmi")]
        [Required(ErrorMessage = "{0}  seçilmelidir")]
        public IFormFile  ImageFile { get; set; }

        [DisplayName("Anasayfa yemeği mi?")]
        public bool IsHome { get; set; }
        [DisplayName("Onaylı Yemek mi?")]
        public bool IsApproved { get; set; }

        [DisplayName("Yemek Kategorileri")]
        public List<Category> Categories { get; set; }

        [Required(ErrorMessage = "En az bir kategori seçmelisiniz")]
        public List<Category> SelectedCategories { get; set; }

    }
}
