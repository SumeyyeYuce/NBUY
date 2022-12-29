namespace YemekSitesi.Web.Models.Dtos
{
    public class FoodDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateAdded { get; set; }
        public string CookingTime { get; set; }
        public string ImageUrl { get; set; }
        public string Url { get; set; }



    }
}
