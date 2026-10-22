namespace MYAcademy_Portfolio.Entities;

public class Certificate
{
    public int CertificateId { get; set; }
    public int IssueYear { get; set; }
    public string CertificateName { get; set; } = null!;
    public string Organization { get; set; } = null!;
    public string CertificateUrl { get; set; } = null!;
}
