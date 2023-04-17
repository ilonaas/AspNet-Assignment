using System.ComponentModel.DataAnnotations;

namespace AspNet_Assignment.ViewModels
{
    public class ProductViewModel
    {
        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "You must enter a product name")]
        public string ProductName { get; set; } = null!;


        [Display(Name = "Price")]
        [Required(ErrorMessage = "You must enter a price")]
        public string Price { get; set; }
    }
}
