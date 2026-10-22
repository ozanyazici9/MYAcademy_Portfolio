namespace MYAcademy_Portfolio.Entities;

public class Experience
{
    public int ExperienceId { get; set; }
    public string Title { get; set; } = null!;
    public string CompanyName { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string SideTitle { get; set; } = null!;
    public string Duration { get; set; } = null!;
    public string WorkType { get; set; } = null!;
    public bool IsActive { get; set; }
}
