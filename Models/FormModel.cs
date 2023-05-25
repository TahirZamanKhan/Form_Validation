using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Form.Models
{
    public class FormModel
    {

 
        [Display(Name = "Full Name")]
        public required string FullName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }

   
        [Display(Name = "Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        public required string Mobile { get; set; }


        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        public required string Address { get; set; }

        [Display(Name = "Sallary")]
        //[DataType(DataType.)]
        public required string Sallary { get; set; }

    
        [Display(Name = "Website")]
        [DataType(DataType.Url)]
        public required string Website { get; set; }


    }
}
