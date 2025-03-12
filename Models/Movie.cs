using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        [Key] // Thuộc tính chỉ định đây là khóa chính (tùy chọn, nếu dùng EF)
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public string Genre { get; set; }

        [Range(1, 100, ErrorMessage = "Price must be between 1 and 100")]
        public decimal Price { get; set; }
    }
}
