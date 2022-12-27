using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ShoppingApp.Web.Models.Dtos
{
    public class OrderDto
    {
        [DisplayName("Ad")]
        [Required(ErrorMessage ="{0} alanı boş bırakılmamalı")]
        public string FirstName { get; set; }


        [DisplayName("Soyad")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalı")]
        public string LastName { get; set; }

        [DisplayName("Adres")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalı")]
        public string Address { get; set; }

        [DisplayName("Şehir")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalı")]
        public string City { get; set; }

        [DisplayName("Telefon Numarası")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalı")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DisplayName("Mail")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalı")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Kartın üzerindeki adSoyad")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalı")]
        public string CardName { get; set; }

        [DisplayName("Kart Numarası")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalı")]
        public string CardNumber { get; set; }

        [DisplayName("Geçerlilik Tarihi Ay")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalı")]
        public string ExpirationMonth { get; set; }

        [DisplayName("Geçerlilik Tarihi Yıl")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalı")]
        public string ExpirationYear { get; set; }

        [DisplayName("Kartın arka yüzündeki 3 haneli güvenlik numarası")]
        [Required(ErrorMessage = "{0} alanı boş bırakılmamalı")]
        public string Cvc { get; set; }
        public CardDto CardDto { get; set; }

    }
}
