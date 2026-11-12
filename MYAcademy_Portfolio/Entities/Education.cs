using System.ComponentModel.DataAnnotations;

namespace MYAcademy_Portfolio.Entities;

public class Education
{
    public int EducationId { get; set; }

    [Required(ErrorMessage = "Başlık boş bırakılamaz.")]
    [MaxLength(100, ErrorMessage = "Başlık en fazla 100 karakter olabilir.")]
    public string Title { get; set; } = null!;

    [Required(ErrorMessage = "Alt başlık boş bırakılamaz.")]
    [MaxLength(150, ErrorMessage = "Alt başlık en fazla 150 karakter olabilir.")]
    public string SubTitle { get; set; } = null!;

    [Required(ErrorMessage = "Açıklama boş bırakılamaz.")]
    [MaxLength(700, ErrorMessage = "Açıklama en fazla 700 karakter olabilir.")]
    public string Description { get; set; } = null!;

    [Required(ErrorMessage = "Süre boş bırakılamaz.")]
    [MaxLength(50, ErrorMessage = "Süre en fazla 50 karakter olabilir.")]
    public string Duration { get; set; } = null!;
}
