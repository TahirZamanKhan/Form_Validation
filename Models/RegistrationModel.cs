using System.ComponentModel.DataAnnotations;

namespace Form.Models
{
    public class RegistrationModel
    {
        [Required]
        public int ID { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password), MaxLength(10)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Confirm Password"), MaxLength(10)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }




    }
}
