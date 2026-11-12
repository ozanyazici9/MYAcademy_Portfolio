using System.ComponentModel.DataAnnotations;

namespace MYAcademy_Portfolio.Entities;

public class Experience
{
    public int ExperienceId { get; set; }

    [Required(ErrorMessage = "Başlık boş bırakılamaz.")]
    [MaxLength(100, ErrorMessage = "Başlık en fazla 100 karakter olabilir.")]
    public string Title { get; set; } = null!;

    [Required(ErrorMessage = "Şirket adı boş bırakılamaz.")]
    [MaxLength(150, ErrorMessage = "Şirket adı en fazla 100 karakter olabilir.")]
    public string CompanyName { get; set; } = null!;

    [Required(ErrorMessage = "Açıklama boş bırakılamaz.")]
    [MaxLength(700, ErrorMessage = "Açıklama en fazla 500 karakter olabilir.")]
    public string Description { get; set; } = null!;

    [Required(ErrorMessage = "Başlangıç tarihi boş bırakılamaz.")]
    [MaxLength(80, ErrorMessage = "Başlangıç tarihi en fazla 80 karakter olabilir.")]
    public string SideTitle { get; set; } = null!;

    [Required(ErrorMessage = "Bitiş tarihi boş bırakılamaz.")]
    [MaxLength(80, ErrorMessage = "Bitiş tarihi en fazla 80 karakter olabilir.")]
    public string Duration { get; set; } = null!;

    [Required(ErrorMessage = "Çalışma türü boş bırakılamaz.")]
    [MaxLength(80, ErrorMessage = "Çalışma türü en fazla 80 karakter olabilir.")]
    public string WorkType { get; set; } = null!;
    public bool IsActive { get; set; }
}
