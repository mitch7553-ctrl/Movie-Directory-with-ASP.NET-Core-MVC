using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Movie_Directory_with_ASP.NET_Core_MVC.Service;
namespace Movie_Directory_with_ASP.NET_Core_MVC.Models
{
    public class Movies : IMovies
    {
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Required")]
        public string Title { get; set; } = string.Empty;


        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Required")]
        [StringLength(100, ErrorMessage = "Genre can't exceed no more than 100 characters.")]
        public string Genre { get; set; }


        [Required(ErrorMessage = "Rating is required. ")]       
        [Range(0.0, 10.0, ErrorMessage = " Ratings are only from 0 to 5.")]
        public decimal Rating { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Year is required")]
        public int Year { get; set; }

        [DataType(DataType.Text)]
        public string Description { get; set; }
        
    }
}
