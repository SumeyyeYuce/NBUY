using BlogApp.Entities.Dtos;

namespace BlogApp.Mvc.Areas.Admin.Models
{
    public class CategoryAddAjaxViewModel
    {
        //Ajak işlemleri için kullanıcgımız metot imzaları burada
        public CategoryAddDto  CategoryAddDto { get; set; }//CategoryAddDto tipinde bir CategoryAddDto
        public string CategoryAddPartial { get; set; }
        public CategoryDto CategoryDto { get; set; }

    }
}
