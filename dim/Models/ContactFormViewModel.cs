using System.ComponentModel.DataAnnotations;

namespace dim.Models
{
    public class ContactFormViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете вашите имена!")]
        [Display(Name = "Вашите имена:")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете вашия email адрес!")]
        [EmailAddress(ErrorMessage = "Моля въведете валиден email адрес")]
        [Display(Name = "Вашия имейл адрес:")]
        public string Email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете вашия телефонен номер!")]
        [MinLength(10)]
        [Display(Name = "Вашия телефонен номер:")]
        public string Phone { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Моля въведете съдържание на съобщението!")]
        [Display(Name = "Съдържание на съобщението:")]
        public string Content { get; set; }
    }
}
