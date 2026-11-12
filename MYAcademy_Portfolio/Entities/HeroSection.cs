using System.ComponentModel.DataAnnotations;

namespace MYAcademy_Portfolio.Entities;

public class HeroSection
{
    public int HeroSectionId { get; set; }

    [Required(ErrorMessage = "Başlık boş bırakılamaz.")]
    [MaxLength(150, ErrorMessage = "Başlık en fazla 150 karakter olabilir.")]
    public string Title { get; set; } = null!;

    [Required(ErrorMessage = "Alt başlık boş bırakılamaz.")]
    [MaxLength(400, ErrorMessage = "Alt başlık en fazla 400 karakter olabilir.")]
    public string SubTitle { get; set; } = null!;

    [Required(ErrorMessage = "Açıklama boş bırakılamaz.")]
    [MaxLength(700, ErrorMessage = "Açıklama en fazla 700 karakter olabilir.")]
    public string Description { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;
}

