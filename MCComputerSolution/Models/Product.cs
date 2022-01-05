using System.ComponentModel.DataAnnotations;

namespace MCComputerSolution.Models
{
    public class Product : BaseEntity
    {
        [Key]
        public int ProductId { get; set; }

        public string? ProductName { get; set; }

        public int AvbQty { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
