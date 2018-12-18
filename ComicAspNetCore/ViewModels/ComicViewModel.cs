using System.ComponentModel.DataAnnotations;

namespace ComicAspNetCore.ViewModels
{
    public class ComicViewModel
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Issue { get; set; }
        public string ImageUrl { get; set; }
    }
}
