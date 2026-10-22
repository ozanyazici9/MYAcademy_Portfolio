namespace MYAcademy_Portfolio.Entities;

public class Skill
{
    public int SkillId { get; set; }
    public string SkillName { get; set; } = null!;
    public string Description { get; set; } = null!;
    public ICollection<Technology> Technologies { get; set; } = new List<Technology>();
}
