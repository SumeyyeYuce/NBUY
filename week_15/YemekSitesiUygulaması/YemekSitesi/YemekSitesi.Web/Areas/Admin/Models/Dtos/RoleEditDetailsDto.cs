namespace YemekSitesi.Web.Areas.Admin.Models.Dtos
{
    public class RoleEditDetailsDto
    {
        public string RoleId { get; set; }

        public string RoleName { get; set; }
        public string[] IdToAdd { get; set; }
        public string[] IdToRemove { get; set; }
    }
}
