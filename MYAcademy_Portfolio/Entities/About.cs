namespace MYAcademy_Portfolio.Entities;

public class About
{
    public int AboutId { get; set; }
    public string NameSurname { get; set; } = null!;
    public string JobTitle { get; set; } = null!;
    public string Location { get; set; } = null!;
    public string Expert { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string OpenToWork { get; set; } = null!;
}
