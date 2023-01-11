namespace YemekSitesi.Web.MailServices.Abstract
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email,string subject,string htmlMessage);
    }
}
