using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BootcampHomework1.Models
{
    public class FormViewModel
    {
        [Required(ErrorMessage = "Bu alan zorunlu, lütfen doldurun")]
        [StringLength(50, ErrorMessage = "İsim alanı 50 karakterden uzun olamaz!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Bu alan zorunlu, lütfen doldurun")]
        [StringLength(50, ErrorMessage = "Soy isim alanı 50 karakterden uzun olamaz!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Bu alan zorunlu, lütfen doldurun")]
        [StringLength(50, ErrorMessage = "E-Mail alanı 50 karakterden uzun olamaz!")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$",ErrorMessage ="E-Mail formatını kontrol edip tekrar deneyin!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Bu alan zorunlu, lütfen doldurun")]
        [DataType(DataType.Password)]
        [MinLength(8,ErrorMessage ="Şifreniz en az 8 karakterden oluşmalıdır")]
        [RegularExpression("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).{8,32}$", ErrorMessage ="Şifreniz en az 1 büyük harf ve 1 rakam içermek zorundadır!")]
        public string Password { get; set; }

    }
}
