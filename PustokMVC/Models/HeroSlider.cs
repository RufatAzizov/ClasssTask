using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace PustokMVC.Models
{
    public class HeroSlider
    {
        public int Id { get; set; }
        [Required, MinLength(3), MaxLength(10)]
        public string Title { get; set; }
        [Required, MinLength(3), MaxLength(30)]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required, MinLength(3), MaxLength(255)]
        public string ImageURL { get; set; }
        public bool IsRight { get; set; }
    }
}
