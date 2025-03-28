using System.ComponentModel.DataAnnotations;

namespace SQLTreeView.Shared.Models
{
    public class Order
    {
        [Key]
        public int? OrderID { get; set; }
        [Required]
        public string? CustomerID { get; set; }
        [Required]
        public int EmployeeID { get; set; }

    }
}
