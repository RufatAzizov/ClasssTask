using System.ComponentModel.DataAnnotations;

namespace Pustok.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required, MaxLength(128)]
        public string ImageUrl { get; set; }
        [Required, MinLength(3), MaxLength(64), DataType("nvarchar")]
        public string Title { get; set; }
        [Required, MinLength(3), MaxLength(128), DataType("nvarchar")]

        public string Text { get; set; }
        public bool IsLeft { get; set; }
    }
}
