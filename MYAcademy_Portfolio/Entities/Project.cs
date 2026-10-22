namespace MYAcademy_Portfolio.Entities;

public class Project
{
    public int ProjectId { get; set; }
    public string ProjectName { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string GithubUrl { get; set; } = null!;
    public string LiveDemoUrl { get; set; } = null!;
    public bool IsActive { get; set; }
    public ICollection<Technology> Technologies { get; set; } = new List<Technology>();
}
