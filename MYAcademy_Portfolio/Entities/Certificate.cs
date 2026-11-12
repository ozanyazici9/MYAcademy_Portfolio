using System.ComponentModel.DataAnnotations;

namespace MYAcademy_Portfolio.Entities;

public class Certificate
{
    public int CertificateId { get; set; }

    [Required(ErrorMessage = "Sertifika yılı boş bırakılamaz.")]
    public int IssueYear { get; set; }

    [Required(ErrorMessage = "Sertifika adı boş bırakılamaz.")]
    [MaxLength(100, ErrorMessage = "Sertifika adı en fazla 100 karakter olabilir.")]
    public string CertificateName { get; set; } = null!;

    [Required(ErrorMessage = "Organizasyon boş bırakılamaz.")]
    [MaxLength(100, ErrorMessage = "Organizasyon en fazla 100 karakter olabilir.")]
    public string Organization { get; set; } = null!;

    [Required(ErrorMessage = "Sertifika URL'si boş bırakılamaz.")]
    [MaxLength(200, ErrorMessage = "Sertifika URL'si en fazla 200 karakter olabilir.")]
    public string CertificateUrl { get; set; } = null!;
}
