using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace YemekSitesi.Web.Areas.Admin.Models.Dtos
{
    public class CategoryUpdateDto
    {
        public int Id { get; set; }

        [DisplayName("Kategori Adı")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olmamaldır")]
        public string Name { get; set; }

        [DisplayName("Kategori Açıklaması")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        [MinLength(5, ErrorMessage = "{0} , {1} karakterden kısa olmamaldır")]
        public string Description { get; set; }

        [DisplayName("Kategori Url")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz")]
        public string Url { get; set; }

    }
}
