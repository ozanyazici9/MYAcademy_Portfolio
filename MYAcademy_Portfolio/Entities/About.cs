using System.ComponentModel.DataAnnotations;

namespace MYAcademy_Portfolio.Entities;

public class About
{
    public int AboutId { get; set; }

    [Required(ErrorMessage = "Ad Soyad boş bırakılamaz.")]
    [MaxLength(100, ErrorMessage = "Ad Soyad en fazla 100 karakter olabilir.")]
    public string NameSurname { get; set; } = null!;

    [Required(ErrorMessage = "Meslek boş bırakılamaz.")]
    [MaxLength(100, ErrorMessage = "Meslek en fazla 100 karakter olabilir.")]
    public string JobTitle { get; set; } = null!;

    [Required(ErrorMessage = "Lokasyon boş bırakılamaz.")]
    [MaxLength(100, ErrorMessage = "Lokasyon en fazla 100 karakter olabilir.")]
    public string Location { get; set; } = null!;

    [Required(ErrorMessage = "Uzmanlık alanı boş bırakılamaz.")]
    [MaxLength(100, ErrorMessage = "Uzmanlık alanı en fazla 100 karakter olabilir.")]
    public string Expert { get; set; } = null!;

    [Required(ErrorMessage = "Email boş bırakılamaz.")]
    [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz.")]
    public string Email { get; set; } = null!;

    [MaxLength(800, ErrorMessage = "Açıklama en fazla 800 karakter olabilir.")]
    public string Description { get; set; } = null!;

    public string OpenToWork { get; set; } = null!;
}
