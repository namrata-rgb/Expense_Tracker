 
using System.ComponentModel.DataAnnotations;

namespace first_api.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; } = string.Empty;

        public double Amount { get; set; }
    }
}
