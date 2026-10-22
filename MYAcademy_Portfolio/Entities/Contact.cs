namespace MYAcademy_Portfolio.Entities;

public class Contact
{
    public int ContactId { get; set; }
    public string Description { get; set; } = null!;
    public string SubDescription { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Location { get; set; } = null!;
    public string LinkedinUrl { get; set; } = null!;
    public string GithubUrl { get; set; } = null!;
}
