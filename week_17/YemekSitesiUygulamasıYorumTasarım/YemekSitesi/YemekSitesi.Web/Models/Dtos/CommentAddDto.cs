namespace YemekSitesi.Web.Models.Dtos
{
    public class CommentAddDto
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime CommentDate { get; set; }
        public string UserId { get; set; }
        public int FoodId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
