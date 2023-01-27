using YemekSitesi.Web.MailServices.Abstract;

namespace YemekSitesi.Web.MailServices.Concrete
{
    public class Pop3EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            throw new NotImplementedException();
        }
    }
}
