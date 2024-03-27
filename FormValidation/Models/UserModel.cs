using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace FormValidation.Models {
    public class UserModel {
        [Display(Name = "Ad Soyad")]
        public string? Name { get; set; }

        [Display(Name = "E-posta Adresi")]
        [EmailAddress]
        public string? Email {get; set;}

        [Display(Name = "Doğum Tarihi")]
        [DataType(DataType.DateTime)]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Telefon Numarası")]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        [Display(Name = "Posta Kodu")]
        [DataType(DataType.PostalCode)]
        public string? PostalCode { get; set; }

        [Display(Name = "Parola")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
