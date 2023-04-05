using AspNet_Assignment.Models.Identity;
using System.ComponentModel.DataAnnotations;

namespace AspNet_Assignment.ViewModels
{ 
    public class RegisterViewModel
    {
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You must enter a firt name")]
      //  [RegularExpression(@"^[A-Za-z_][A-Za-z0-9_]*$", ErrorMessage = "You must enter a valid first name")]
        public string FirstName { get; set; } = null!;

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You must enter a last name")]
       // [RegularExpression(@"^[A-Za-z_][A-Za-z0-9_]*$", ErrorMessage = "You must enter a valid last name")]
        public string LastName { get; set; } = null!;

        [Display(Name = "E-mail Address")]
        [Required(ErrorMessage = "You must enter an e-mail address")]
       // [RegularExpression(@"^[a-zA-Z0-9.%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "You must enter a valid e-mail address")]
        public string Email { get; set; } = null!;

        [Display(Name = "Street Name")]
        [Required(ErrorMessage = "You must enter a streetname")]
     //   [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9])*$", ErrorMessage = "You must enter a valid streetname")]
        public string StreetName { get; set; } = null!;
        
        [Display(Name = "PostalCode")]
        [Required(ErrorMessage = "You must enter a postalcode")]
     //   [RegularExpression(@"^(?=.*[0-9]).{5,}$", ErrorMessage = "You must enter a valid postalcode")]
        public string PostalCode { get; set; } = null!;

        [Display(Name = "City")]
        [Required(ErrorMessage = "You must enter a city")]
     //   [RegularExpression(@"^[A-Za-z_][A-Za-z0-9_]*$", ErrorMessage = "You must enter a valid city")]
        public string City { get; set; } = null!;


        [Display(Name = "Password")]
        [Required(ErrorMessage = "You must enter a password")]
       // [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$", ErrorMessage = "You must enter a valid password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;

        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "You must confirm your password")]
        [Compare(nameof(Password), ErrorMessage = "You password does not match")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = null!;



        public static implicit operator CustomIdentityUser(RegisterViewModel registerViewModel)
        {
            return new CustomIdentityUser
            {
                FirstName = registerViewModel.FirstName,
                LastName = registerViewModel.LastName,
                Email = registerViewModel.Email,
                UserName = registerViewModel.Email,
                StreetName = registerViewModel.StreetName,
                PostalCode = registerViewModel.PostalCode,
                City = registerViewModel.City
            };
        }

    }
}
