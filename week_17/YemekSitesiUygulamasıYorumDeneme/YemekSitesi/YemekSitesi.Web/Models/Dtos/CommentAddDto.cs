namespace YemekSitesi.Web.Models.Dtos
{
    public class CommentAddDto
    {
        public string Message { get; set; }
        public DateTime CommentDate { get; set; }
        public string UserId { get; set; }
        public int FoodId { get; set; }

    }
}
