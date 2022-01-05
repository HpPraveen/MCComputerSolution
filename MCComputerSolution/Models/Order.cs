using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MCComputerSolution.Models
{
    public class Order : BaseEntity
    {
        [Key]
        public int OId { get; set; }

        public string? OrderNumber { get; set; }

        public string? CustomerName { get; set; }

        public DateTime OrderDate { get; set; }

        public int ProductId { get; set; }

        public string? ProductName { get; set; }

        public int OrderQty { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Discount { get; set; }

        [Required]
        public decimal TotalAmt { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product? Product { get; set; }
    }
}
