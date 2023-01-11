namespace YemekSitesi.Web.Models.Dtos
{
    public class FavoriteDto
    {
        public int FavoriteId { get; set; }
        public List<FavoriteItemDto> FavoriteItems { get; set; }

        //public decimal? TotalPrice()
        //{
        //    return FavoriteItems.Sum(ci => ci.ItemPrice * ci.Quantity);
        //}
    }

    public class FavoriteItemDto
    {
        public int FavoriteItemId { get; set; }
        public int FoodId { get; set; }
        public string FoodName { get; set; }
        //public decimal? ItemPrice { get; set; }
        public string ImageUrl { get; set; }
        public int FavortiteNumber { get; set; }

    }
}
