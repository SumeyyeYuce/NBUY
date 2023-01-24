using YemekSitesi.Entity.Concrete;

namespace YemekSitesi.Web.Models.Dtos
{
    public class FoodDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }
        public string CookingTime { get; set; }
        public List<Category> Categories { get; set; }
        public List<Comment> Comments { get; set; }
        public CommentAddDto CommentAddDto { get; set; }
    }
}
