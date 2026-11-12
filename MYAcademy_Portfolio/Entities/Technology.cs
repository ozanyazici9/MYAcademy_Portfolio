using System.ComponentModel.DataAnnotations;

namespace MYAcademy_Portfolio.Entities;

public class Technology
{
    public int TechnologyId { get; set; }

    [Required(ErrorMessage = "Teknoloji adı boş bırakılamaz.")]
    [MaxLength(70, ErrorMessage = "Teknoloji adı en fazla 70 karakter olabilir.")]
    [MinLength(3, ErrorMessage = "Teknoloji adı en az 3 karakter olmalı.")]
    public string TechnologyName { get; set; } = null!;
    public bool IsActive { get; set; }

    // Skill ile bire çok ilişki (çok tarafı)
    public int SkillId { get; set; }
    public Skill Skill { get; set; } = null!;

    // Project ile çoka çok
    public ICollection<Project> Projects { get; set; } = new List<Project>();
}
