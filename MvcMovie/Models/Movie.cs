using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models;

public class Movie
{
    public int Id { get; set; }

    [Display(Name = "Tytuł")]
    [StringLength(60, MinimumLength = 3, ErrorMessage = "Tytuł musi mieć od 3 do 60 znaków")]
    [Required(ErrorMessage = "Tytuł jest wymagany")]
    public string? Title { get; set; }

    [Display(Name = "Data premiery")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "Data jest wymagana")]
    public DateTime ReleaseDate { get; set; }

    [Display(Name = "Gatunek")]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Gatunek musi zaczynać się z wielkiej litery i zawierać tylko litery")]
    [Required(ErrorMessage = "Gatunek jest wymagany")]
    [StringLength(30)]
    public string? Genre { get; set; }

    [Display(Name = "Cena")]
    [Range(1, 100, ErrorMessage = "Cena musi być z przedziału 1 - 100")]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}