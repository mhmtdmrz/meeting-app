using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Ad alanı zorunlu.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Telefon alanı zorunlu.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Email alanı zorunlu.")]
        [EmailAddress (ErrorMessage = "Hatalı Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Katılım durumunuzu seçiniz.")]
        public bool WillAttend { get; set; }
    }
}