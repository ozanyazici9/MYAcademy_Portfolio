namespace MYAcademy_Portfolio.Entities;

public class Education
{
    public int EducationId { get; set; }
    public string Title { get; set; } = null!;
    public string SubTitle { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Duration { get; set; } = null!;
}
