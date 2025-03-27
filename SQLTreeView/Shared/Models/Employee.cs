using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Shared.Models
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
