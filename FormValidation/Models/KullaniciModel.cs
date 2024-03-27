using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace FormValidation.Models {
    public class Kullanici {
        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        [StringLength(50, ErrorMessage = "50 karakterden fazla olamaz")]
        public string? Ad { get; set; }

        [Required(ErrorMessage = "Soyad alanı boş geçilemez")]
        [StringLength(50, ErrorMessage = "50 karakterden fazla olamaz")]

        public string? Soyad { get; set; }

        [Required(ErrorMessage = "Email alanı boş geçilemez")]
        [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş geçilemez")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}",
                    ErrorMessage = "Harf ve Karakterden oluşan en az 8 karakter giriniz.")]
        public string? Sifre { get; set; }
        [Required(ErrorMessage = "Şifrenizi tekrar giriniz")]
        [Compare("Sifre", ErrorMessage = "Şifreler Aynı Değil")]
        public string? SifreTekrar { get; set; }
        [Phone(ErrorMessage = "Geçerli telefon numarası giriniz.")]
        public string? Telefon { get; set; }
    }
}