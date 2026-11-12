using System.ComponentModel.DataAnnotations;

namespace MYAcademy_Portfolio.Entities;

public class Message
{
    public int MessageId { get; set; }

    [Required(ErrorMessage = "Ad Soyad boş bırakılamaz.")]
    [MaxLength(100, ErrorMessage = "Ad Soyad en fazla 100 karakter olabilir.")]
    public string NameSurname { get; set; } = null!;

    [Required(ErrorMessage = "Email boş bırakılamaz.")]
    [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz.")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "Konu boş bırakılamaz.")]
    [MaxLength(200, ErrorMessage = "Konu en fazla 200 karakter olabilir.")]
    public string Subject { get; set; } = null!;

    [Required(ErrorMessage = "Mesaj boş bırakılamaz.")]
    [MaxLength(850, ErrorMessage = "Mesaj en fazla 850 karakter olabilir.")]
    public string MessageDetail { get; set; } = null!;

    public DateTime SendDate { get; set; }

    public bool IsRead { get; set; }
}
