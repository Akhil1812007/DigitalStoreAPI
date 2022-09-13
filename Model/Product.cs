using System.ComponentModel.DataAnnotations;

namespace DigitalStoreAPI.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Enter the Product Name")]
        [StringLength(50)]
        public string? ProductName { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Value must be greater than 0")]
        public int? UnitPrice { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Value must be greater than 0")]

        public int? ProductQnt { get; set; }
        public string? ProductImage { get; set; }
    }
}
