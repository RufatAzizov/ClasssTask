using System.ComponentModel.DataAnnotations;

namespace PustokMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, MaxLength(64)]
        public string Title { get; set; }
        [Required, MinLength(3), MaxLength(30)]
        public string Description { get; set; }
        [Required, MinLength(3), MaxLength(40)]
        public bool IsDeleted { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int ProductCode { get; set; }
        public int InStock { get; set; }
        List<ProductImages> ProductPcs { get; set;}



    }
}
