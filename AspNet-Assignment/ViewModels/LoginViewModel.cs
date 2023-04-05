using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AspNet_Assignment.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "E-mail Address")]
        [Required(ErrorMessage = "You must enter an e-mail address")]
        //[RegularExpression(@"^[a-zA-Z0-9.%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "You must enter a valid e-mail address")]
        public string Email { get; set; } = null!;

        [Display(Name = "Password")]
        [Required(ErrorMessage = "You must enter a password")]
        //[RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$", ErrorMessage = "You must enter a valid password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
