using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Web.Areas.Admin.Models.Dtos
{
    public class RoleDto
    {
       
        public string Id { get; set; }

        [DisplayName("Role adı")]
        [Required(ErrorMessage ="{0} alanı boş bırakılmamalı")]
        public string Name { get; set; }


        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalı")]
        public string Description { get; set; }
    }
}
