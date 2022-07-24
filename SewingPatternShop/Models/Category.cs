using System.ComponentModel.DataAnnotations;

namespace SewingPatternShop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Please enter a category name.")]
        public string Name { get; set; }
    }
}
