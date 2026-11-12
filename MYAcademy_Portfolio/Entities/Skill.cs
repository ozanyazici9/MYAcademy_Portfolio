using System.ComponentModel.DataAnnotations;

namespace MYAcademy_Portfolio.Entities;

public class Skill
{
    public int SkillId { get; set; }

    [Required(ErrorMessage = "Yetenek adı boş bırakılamaz.")]
    [MaxLength(90, ErrorMessage = "Yetenek adı en fazla 90 karakter olabilir.")]
    [MinLength(3, ErrorMessage = "Yetenek adı en az 3 karakter olmalı.")]
    public string SkillName { get; set; } = null!;

    [MaxLength(700, ErrorMessage = "Açıklama en fazla 700 karakter olabilir.")]
    public string Description { get; set; } = null!;
    public ICollection<Technology> Technologies { get; set; } = new List<Technology>();
}
