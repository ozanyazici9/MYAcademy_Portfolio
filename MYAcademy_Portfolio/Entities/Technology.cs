namespace MYAcademy_Portfolio.Entities;

public class Technology
{
    public int TechnologyId { get; set; }
    public string TechnologyName { get; set; } = null!;
    public bool IsActive { get; set; }

    // Skill ile bire çok ilişki (çok tarafı)
    public int SkillId { get; set; }
    public Skill Skill { get; set; } = null!;

    // Project ile çoka çok
    public ICollection<Project> Projects { get; set; } = new List<Project>();
}
