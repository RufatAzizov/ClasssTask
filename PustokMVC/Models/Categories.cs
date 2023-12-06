using System.ComponentModel.DataAnnotations;
using System.Drawing;
namespace PustokMVC.Models
{
    public class Categories
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required, MaxLength(50)]
        public bool IsDeleted { get; set; }
        [Required]
        public int ParentCategoryId { get; set; }



    }
}
