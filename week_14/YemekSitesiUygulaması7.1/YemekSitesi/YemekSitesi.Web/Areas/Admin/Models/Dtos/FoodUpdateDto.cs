using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Web.Areas.Admin.Models.Dtos
{
    public class FoodUpdateDto
    {
        public int Id { get; set; }

        [DisplayName("Yemek Adı")]
        [Required(ErrorMessage = "{0} boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olamaz")]

        public string Name { get; set; }

        [DisplayName("Malzemeler")]
        [Required(ErrorMessage = "{0} boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olamaz")]
       
        public string Material { get; set; }

        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olamaz")]
       
        public string Description { get; set; }

        [DisplayName("Yemek Resmi")]
        public IFormFile ImageFile { get; set; }

        [DisplayName("Anasayfa yemeği mi?")]
        public bool IsHome { get; set; }
        [DisplayName("Onaylı Yemek mi?")]
        public bool IsApproved { get; set; }

        [DisplayName("Yemek Kategorileri")]
        public List<Category> Categories { get; set; }

        [DisplayName("Hazırlanma ve Pişirme Süresi")]
        public string CookingTime { get; set; }

        [Required(ErrorMessage = "En az bir kategori seçmelisiniz")]
        public int[] SelectedCategoryIds { get; set; }

        public string ImageUrl { get; set; }
    }
}
