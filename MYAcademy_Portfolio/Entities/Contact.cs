using System.ComponentModel.DataAnnotations;

namespace MYAcademy_Portfolio.Entities;

public class Contact
{
    public int ContactId { get; set; }

    [Required(ErrorMessage = "Açıklama boş bırakılamaz.")]
    [MaxLength(400, ErrorMessage = "Açıklama en fazla 400 karakter olabilir.")]
    public string Description { get; set; } = null!;

    [Required(ErrorMessage = "Alt açıklama boş bırakılamaz.")]
    [MaxLength(300, ErrorMessage = "Alt açıklama en fazla 300 karakter olabilir.")]
    public string SubDescription { get; set; } = null!;

    [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz.")]
    public string Email { get; set; } = null!;
    public string Location { get; set; } = null!;
    public string LinkedinUrl { get; set; } = null!;
    public string GithubUrl { get; set; } = null!;
}
