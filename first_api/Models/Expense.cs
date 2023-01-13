using System.ComponentModel.DataAnnotations;

namespace first_api.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }  

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public double Amount { get; set; }

        public string Description { get; set; } = string.Empty;

        public int CategoryId { get; set; }

        public Category? Category { get; set; }

        public DateTime Date { get; set; } = DateTime.Today;
    }
}
